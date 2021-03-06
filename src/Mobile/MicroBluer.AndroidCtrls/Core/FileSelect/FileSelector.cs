﻿namespace MicroBluer.AndroidCtrls.FileSelect
{
    using Android.Content;
    using System.Threading;
    using System.Threading.Tasks;

    public class FileSelector
    {
        public static async Task<string> SelectSingle(Context context, SelectorType type, string older)
        {
            var result = await OpenDialog(context, type,false, older);
            return result == null ? string.Empty : result.SelectItem;
        }

        public static async Task<string[]> SelectMany(Context context, SelectorType type, string[] olders)
        {
            var result = await OpenDialog(context, type, true, paths: olders);
            return result == null ? new string[0] : result.SelectItems;
        }

        static Task<SelectorResult> OpenDialog(Context context, SelectorType type, bool isSelectMany, string path = null, string[] paths = null)
        {
            return Task.Factory.StartNew<SelectorResult>(() =>
            {
                SelectorResult selected = null;

                var waitSelectedResetEvent = new ManualResetEvent(false);
                var selectorIntent = new Intent(context, typeof(FileSelectorActivity));
                FileSelectorActivity.IsSelectMany = isSelectMany;
                FileSelectorActivity.SelectorType = type;

                FileSelectorActivity.OnCanceled += () =>
                {
                    selected = new SelectorResult { SelectItem = path, SelectItems = paths };
                    waitSelectedResetEvent.Set();
                };
                FileSelectorActivity.OnSelectorCompleted += (SelectorResult result) =>
                {
                    selected = result;
                    waitSelectedResetEvent.Set();
                };

                context.StartActivity(selectorIntent);
                waitSelectedResetEvent.WaitOne();
                return selected;
            });
        }
    }
}