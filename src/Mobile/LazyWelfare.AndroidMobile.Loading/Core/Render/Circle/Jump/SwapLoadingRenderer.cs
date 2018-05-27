﻿

namespace LazyWelfare.AndroidMobile.Loading.Render.Circle.Jump
{
	using Context = Android.Content.Context;
	using Canvas = Android.Graphics.Canvas;
	using Color = Android.Graphics.Color;
	using ColorFilter = Android.Graphics.ColorFilter;
	using Paint = Android.Graphics.Paint;
	using AccelerateDecelerateInterpolator = Android.Views.Animations.AccelerateDecelerateInterpolator;
    using Interpolator = Android.Views.Animations.IInterpolator;
    using Android.Graphics;
    using System;

    public class SwapLoadingRenderer : LoadingRenderer
	{
		private static readonly Interpolator ACCELERATE_DECELERATE_INTERPOLATOR = new AccelerateDecelerateInterpolator();

		private const long ANIMATION_DURATION = 2500;

		private const int DEFAULT_CIRCLE_COUNT = 5;

		private const float DEFAULT_BALL_RADIUS = 7.5f;
		private static readonly float DEFAULT_WIDTH = 15.0f * 11;
		private static readonly float DEFAULT_HEIGHT = 15.0f * 5;
		private const float DEFAULT_STROKE_WIDTH = 1.5f;

		private static readonly int DEFAULT_COLOR = Color.White;

        private readonly Paint mPaint = new Paint(PaintFlags.AntiAlias);

		private int mColor;

		private int mSwapIndex;
		private int mBallCount;

		private float mBallSideOffsets;
		private float mBallCenterY;
		private float mBallRadius;
		private float mBallInterval;
		private float mSwapBallOffsetX;
		private float mSwapBallOffsetY;
		private float mASwapThreshold;

		private float mStrokeWidth;

		internal SwapLoadingRenderer(Context context) : base(context)
		{

			Init(context);
			AdjustParams();
			SetupPaint();
		}

		private void Init(Context context)
		{
			mWidth = DensityUtil.dip2px(context, DEFAULT_WIDTH);
			mHeight = DensityUtil.dip2px(context, DEFAULT_HEIGHT);
			mBallRadius = DensityUtil.dip2px(context, DEFAULT_BALL_RADIUS);
			mStrokeWidth = DensityUtil.dip2px(context, DEFAULT_STROKE_WIDTH);

			mColor = DEFAULT_COLOR;
			mDuration = ANIMATION_DURATION;
			mBallCount = DEFAULT_CIRCLE_COUNT;

			mBallInterval = mBallRadius;
		}

		private void AdjustParams()
		{
			mBallCenterY = mHeight / 2.0f;
			mBallSideOffsets = (mWidth - mBallRadius * 2 * mBallCount - mBallInterval * (mBallCount - 1)) / 2.0f;

			mASwapThreshold = 1.0f / mBallCount;
		}

		private void SetupPaint()
		{
			mPaint.Color = new Color (mColor);
			mPaint.StrokeWidth = mStrokeWidth;
		}

		protected internal override void Draw(Canvas canvas)
		{
			int saveCount = canvas.Save();

			for (int i = 0; i < mBallCount; i++)
			{
				if (i == mSwapIndex)
				{
					mPaint.SetStyle(Paint.Style.Fill) ;
					canvas.DrawCircle(mBallSideOffsets + mBallRadius * (i * 2 + 1) + i * mBallInterval + mSwapBallOffsetX, mBallCenterY - mSwapBallOffsetY, mBallRadius, mPaint);
				}
				else if (i == (mSwapIndex + 1) % mBallCount)
				{
					mPaint.SetStyle(Paint.Style.Stroke) ;
                    canvas.DrawCircle(mBallSideOffsets + mBallRadius * (i * 2 + 1) + i * mBallInterval - mSwapBallOffsetX, mBallCenterY + mSwapBallOffsetY, mBallRadius - mStrokeWidth / 2, mPaint);
				}
				else
				{
					mPaint.SetStyle(Paint.Style.Stroke) ;
					canvas.DrawCircle(mBallSideOffsets + mBallRadius * (i * 2 + 1) + i * mBallInterval, mBallCenterY, mBallRadius - mStrokeWidth / 2, mPaint);
				}
			}

			canvas.RestoreToCount(saveCount);
		}

		protected internal override void ComputeRender(float renderProgress)
		{
			mSwapIndex = (int)(renderProgress / mASwapThreshold);

			// Swap trace : x^2 + y^2 = r ^ 2
			float swapTraceProgress = ACCELERATE_DECELERATE_INTERPOLATOR.GetInterpolation((renderProgress - mSwapIndex * mASwapThreshold) / mASwapThreshold);

			float swapTraceRadius = mSwapIndex == mBallCount - 1 ? (mBallRadius * 2 * (mBallCount - 1) + mBallInterval * (mBallCount - 1)) / 2 : (mBallRadius * 2 + mBallInterval) / 2;

			// Calculate the X offset of the swap ball
			mSwapBallOffsetX = mSwapIndex == mBallCount - 1 ? -swapTraceProgress * swapTraceRadius * 2 : swapTraceProgress * swapTraceRadius * 2;

			// if mSwapIndex == mBallCount - 1 then (swapTraceRadius, swapTraceRadius) as the origin of coordinates
			// else (-swapTraceRadius, -swapTraceRadius) as the origin of coordinates
			float xCoordinate = mSwapIndex == mBallCount - 1 ? mSwapBallOffsetX + swapTraceRadius : mSwapBallOffsetX - swapTraceRadius;

			// Calculate the Y offset of the swap ball
			mSwapBallOffsetY = (float)(mSwapIndex % 2 == 0 && mSwapIndex != mBallCount - 1 ? Math.Sqrt(Math.Pow(swapTraceRadius, 2.0f) - Math.Pow(xCoordinate, 2.0f)) : -Math.Sqrt(Math.Pow(swapTraceRadius, 2.0f) - Math.Pow(xCoordinate, 2.0f)));

		}

		protected internal override int Alpha
		{
			set
			{
				mPaint.Alpha = value;
			}
		}

		protected internal override ColorFilter ColorFilter
		{
			set
			{
				mPaint.SetColorFilter(value);
			}
		}

		protected internal override void Reset()
		{
		}

		private void Apply(Builder builder)
		{
			this.mWidth = builder.mWidth > 0 ? builder.mWidth : this.mWidth;
			this.mHeight = builder.mHeight > 0 ? builder.mHeight : this.mHeight;
			this.mStrokeWidth = builder.mStrokeWidth > 0 ? builder.mStrokeWidth : this.mStrokeWidth;

			this.mBallRadius = builder.mBallRadius > 0 ? builder.mBallRadius : this.mBallRadius;
			this.mBallInterval = builder.mBallInterval > 0 ? builder.mBallInterval : this.mBallInterval;
			this.mBallCount = builder.mBallCount > 0 ? builder.mBallCount : this.mBallCount;

			this.mColor = builder.mColor != 0 ? builder.mColor : this.mColor;

			this.mDuration = builder.mDuration > 0 ? builder.mDuration : this.mDuration;

			AdjustParams();
			SetupPaint();
		}

		public class Builder
		{
			internal Context mContext;

			internal int mWidth;
			internal int mHeight;
			internal int mStrokeWidth;

			internal int mBallCount;
			internal int mBallRadius;
			internal int mBallInterval;

			internal int mDuration;

			internal int mColor;

			public Builder(Context mContext)
			{
				this.mContext = mContext;
			}

			public virtual Builder SetWidth(int width)
			{
				this.mWidth = width;
				return this;
			}

			public virtual Builder SetHeight(int height)
			{
				this.mHeight = height;
				return this;
			}

			public virtual Builder SetStrokeWidth(int strokeWidth)
			{
				this.mStrokeWidth = strokeWidth;
				return this;
			}

			public virtual Builder SetBallRadius(int ballRadius)
			{
				this.mBallRadius = ballRadius;
				return this;
			}

			public virtual Builder SetBallInterval(int ballInterval)
			{
				this.mBallInterval = ballInterval;
				return this;
			}

			public virtual Builder SetBallCount(int ballCount)
			{
				this.mBallCount = ballCount;
				return this;
			}

			public virtual Builder SetColor(int color)
			{
				this.mColor = color;
				return this;
			}

			public virtual Builder SetDuration(int duration)
			{
				this.mDuration = duration;
				return this;
			}

			public virtual SwapLoadingRenderer Build()
			{
				SwapLoadingRenderer loadingRenderer = new SwapLoadingRenderer(mContext);
				loadingRenderer.Apply(this);
				return loadingRenderer;
			}
		}
	}

}