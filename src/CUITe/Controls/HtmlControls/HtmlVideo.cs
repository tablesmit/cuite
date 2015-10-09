﻿using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a video control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlVideo : HtmlControl<CUITControls.HtmlVideo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlVideo"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlVideo(By searchConfiguration = null)
            : this(new CUITControls.HtmlVideo(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlVideo"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlVideo(CUITControls.HtmlVideo sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the value of autoplay attribute of the media.
        /// </summary>
        public bool AutoPlay
        {
            get
            {
                WaitForControlReady();
                return SourceControl.AutoPlay;
            }
        }

        /// <summary>
        /// Gets the current source of the media.
        /// </summary>
        public string CurrentSrc
        {
            get
            {
                WaitForControlReady();
                return SourceControl.CurrentSrc;
            }
        }

        /// <summary>
        /// Gets the current playing time of the media.
        /// </summary>
        public TimeSpan CurrentTime
        {
            get
            {
                WaitForControlReady();
                return SourceControl.CurrentTime;
            }
        }

        /// <summary>
        /// Gets the current playing time of the media as string.
        /// </summary>
        public string CurrentTimeAsString
        {
            get
            {
                WaitForControlReady();
                return SourceControl.CurrentTimeAsString;
            }
        }

        /// <summary>
        /// Gets the duration of the media.
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Duration;
            }
        }

        /// <summary>
        /// Gets the duration of the media as string.
        /// </summary>
        public string DurationAsString
        {
            get
            {
                WaitForControlReady();
                return SourceControl.DurationAsString;
            }
        }

        /// <summary>
        /// Gets the ended state of the media.
        /// </summary>
        public bool Ended
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Ended;
            }
        }

        /// <summary>
        /// Gets the value of loop attribute of the media.
        /// </summary>
        public bool Loop
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Loop;
            }
        }

        /// <summary>
        /// Gets the muted state of the media.
        /// </summary>
        public bool Muted
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Muted;
            }
        }

        /// <summary>
        /// Gets the paused state of the media.
        /// </summary>
        public bool Paused
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Paused;
            }
        }

        /// <summary>
        /// Gets the playback rate of the media.
        /// </summary>
        public float PlaybackRate
        {
            get
            {
                WaitForControlReady();
                return SourceControl.PlaybackRate;
            }
        }

        /// <summary>
        /// Gets the value of poster attribute of the video.
        /// </summary>
        public string Poster
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Poster;
            }
        }

        /// <summary>
        /// Gets the ready state value of the media.
        /// </summary>
        public int ReadyState
        {
            get
            {
                WaitForControlReady();
                return SourceControl.ReadyState;
            }
        }

        /// <summary>
        /// Gets the seeking state of the media.
        /// </summary>
        public bool Seeking
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Seeking;
            }
        }

        /// <summary>
        /// Gets the value of src attribute of the media.
        /// </summary>
        public string Src
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Src;
            }
        }

        /// <summary>
        /// Gets the height of the video.
        /// </summary>
        public int VideoHeight
        {
            get
            {
                WaitForControlReady();
                return SourceControl.VideoHeight;
            }
        }

        /// <summary>
        /// Gets the width of the video.
        /// </summary>
        public int VideoWidth
        {
            get
            {
                WaitForControlReady();
                return SourceControl.VideoWidth;
            }
        }

        /// <summary>
        /// Gets the current volume of the media.
        /// </summary>
        public float Volume
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Volume;
            }
        }
    }
}