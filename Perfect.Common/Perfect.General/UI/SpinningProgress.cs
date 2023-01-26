using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Perfect.Common.UI
{
    public partial class SpinningProgress  
    { 
        private Color _mInactiveColour = Color.FromArgb( 218, 218, 218 ); 
        private Color _mActiveColour = Color.FromArgb( 35, 146, 33 ); 
        private Color _mTransistionColour = Color.FromArgb( 129, 242, 121 ); 
        
        private Region _innerBackgroundRegion; 
        private System.Drawing.Drawing2D.GraphicsPath[] segmentPaths = new System.Drawing.Drawing2D.GraphicsPath[ 12 ]; 
        
        private bool _mAutoIncrement = true; 
        private double _mIncrementFrequency = 100; 
        private bool _mBehindIsActive = true; 
        private int _mTransitionSegment = 0; 
        
        private System.Timers.Timer _mAutoRotateTimer;
        [System.ComponentModel.DefaultValue(typeof(Color), "218, 218, 218")]
        public Color InactiveSegmentColour 
        { 
            get 
            { 
                return _mInactiveColour; 
            } 
            set 
            { 
                _mInactiveColour = value; 
                Invalidate(); 
            } 
        }
        [System.ComponentModel.DefaultValue(typeof(Color), "35, 146, 33")]
        public Color ActiveSegmentColour 
        { 
            get 
            { 
                return _mActiveColour; 
            } 
            set 
            { 
                _mActiveColour = value; 
                Invalidate(); 
            } 
        } 
        [ System.ComponentModel.DefaultValue( typeof( Color ), "129, 242, 121" ) ]
        public Color TransistionSegmentColour 
        { 
            get 
            { 
                return _mTransistionColour; 
            } 
            set 
            { 
                _mTransistionColour = value; 
                Invalidate(); 
            } 
        }
        [System.ComponentModel.DefaultValue(true)]
        public bool BehindTransistionSegmentIsActive 
        { 
            get 
            { 
                return _mBehindIsActive; 
            } 
            set 
            { 
                _mBehindIsActive = value; 
                Invalidate(); 
            } 
        }
        [System.ComponentModel.DefaultValue(-1)]
        public int TransistionSegment 
        { 
            get 
            { 
                return _mTransitionSegment; 
            } 
            set 
            { 
                if ( value > 11 || value < -1 ) 
                { 
                    throw new ArgumentException( "TransistionSegment must be between -1 and 11" ); 
                } 
                _mTransitionSegment = value; 
                Invalidate(); 
            } 
        }
        [System.ComponentModel.DefaultValue(true)]
        public bool AutoIncrement 
        { 
            get 
            { 
                return _mAutoIncrement; 
            } 
            set 
            { 
                _mAutoIncrement = value; 
                
                if ( value == false && _mAutoRotateTimer != null ) 
                { 
                    _mAutoRotateTimer.Dispose(); 
                    _mAutoRotateTimer = null; 
                } 
                
                if ( value == true && _mAutoRotateTimer == null ) 
                { 
                    _mAutoRotateTimer = new System.Timers.Timer( _mIncrementFrequency ); 
                    _mAutoRotateTimer.Elapsed += IncrementTransisionSegment; 
                    _mAutoRotateTimer.Start(); 
                } 
            } 
        }
        [System.ComponentModel.DefaultValue(100)]
        public double AutoIncrementFrequency 
        { 
            get 
            { 
                return _mIncrementFrequency; 
            } 
            set 
            { 
                _mIncrementFrequency = value; 
                
                if ( _mAutoRotateTimer != null ) 
                { 
                    AutoIncrement = false; 
                    AutoIncrement = true; 
                } 
            } 
        } 
        
        public SpinningProgress() 
        { 
            //  This call is required by the Windows Form Designer.
            InitializeComponent(); 
            
            //  Add any initialization after the InitializeComponent() call.
            CalculateSegments(); 
            
            _mAutoRotateTimer = new System.Timers.Timer( _mIncrementFrequency ); 
            _mAutoRotateTimer.Elapsed += new System.Timers.ElapsedEventHandler( IncrementTransisionSegment );
            this.DoubleBuffered = true;
            _mAutoRotateTimer.Start(); 

            this.EnabledChanged += new EventHandler( SpinningProgress_EnabledChanged ); 
            // events handled by ProgressDisk_Paint
            this.Paint += new PaintEventHandler(ProgressDisk_Paint); 
            // events handled by ProgressDisk_Resize
            this.Resize += new EventHandler( ProgressDisk_Resize); 
            // events handled by ProgressDisk_SizeChanged
            this.SizeChanged += new EventHandler(ProgressDisk_SizeChanged); 
        } 
        
        private void IncrementTransisionSegment( object sender, System.Timers.ElapsedEventArgs e ) 
        { 
            if ( _mTransitionSegment == 11 ) 
            { 
                _mTransitionSegment = 0; 
                _mBehindIsActive = !( _mBehindIsActive ); 
            } 
            else if ( _mTransitionSegment == -1 ) 
            { 
                _mTransitionSegment = 0; 
            } 
            else 
            { 
                _mTransitionSegment += 1; 
            } 
            
            Invalidate(); 
        } 
        
        
        private void CalculateSegments() 
        { 
            Rectangle rctFull = new Rectangle( 0, 0, this.Width, this.Height ); 
            var rctInner = new Rectangle( ((this.Width *  7) / 30),
                                                ((this.Height *  7) / 30),
                                                (this.Width -  ((this.Width *  14 ) / 30 )),
                                                (this.Height - ((this.Height * 14) / 30 ))); 

            System.Drawing.Drawing2D.GraphicsPath pthInnerBackground = null; 
            
            // Create 12 segment pieces
            for ( int intCount=0; intCount < 12; intCount++ ) 
            { 
                segmentPaths[ intCount ] = new System.Drawing.Drawing2D.GraphicsPath(); 
                
                // We subtract 90 so that the starting segment is at 12 o'clock
                segmentPaths[ intCount ].AddPie( rctFull, ( intCount * 30 ) - 90, 25 ); 
            } 
            
            // Create the center circle cut-out
            pthInnerBackground = new System.Drawing.Drawing2D.GraphicsPath(); 
            pthInnerBackground.AddPie( rctInner, 0, 360 ); 
            _innerBackgroundRegion = new Region( pthInnerBackground ); 
        } 
        
        
        private void SpinningProgress_EnabledChanged( object sender, System.EventArgs e ) 
        { 
            if ( Enabled == true ) 
            { 
                if ( _mAutoRotateTimer != null ) 
                { 
                    _mAutoRotateTimer.Start(); 
                } 
            } 
            else 
            { 
                if ( _mAutoRotateTimer != null ) 
                { 
                    _mAutoRotateTimer.Stop(); 
                } 
            } 
        } 
        
        
        private void ProgressDisk_Paint( object sender, PaintEventArgs e ) 
        { 
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
            e.Graphics.ExcludeClip( _innerBackgroundRegion ); 
            
            for ( int intCount=0; intCount < 12; intCount++ ) 
            { 
                if ( this.Enabled ) 
                { 
                    if ( intCount == _mTransitionSegment ) 
                    { 
                        // If this segment is the transistion segment, colour it differently
                        e.Graphics.FillPath( new SolidBrush( _mTransistionColour ), segmentPaths[ intCount ] ); 
                    } 
                    else if ( intCount < _mTransitionSegment ) 
                    { 
                        // This segment is behind the transistion segment
                        if ( _mBehindIsActive ) 
                        { 
                            // If behind the transistion should be active, 
                            // colour it with the active colour
                            e.Graphics.FillPath( new SolidBrush( _mActiveColour ), segmentPaths[ intCount ] ); 
                        } 
                        else 
                        { 
                            // If behind the transistion should be in-active, 
                            // colour it with the in-active colour
                            e.Graphics.FillPath( new SolidBrush( _mInactiveColour ), segmentPaths[ intCount ] ); 
                        } 
                    } 
                    else 
                    { 
                        // This segment is ahead of the transistion segment
                        if ( _mBehindIsActive ) 
                        { 
                            // If behind the the transistion should be active, 
                            // colour it with the in-active colour
                            e.Graphics.FillPath( new SolidBrush( _mInactiveColour ), segmentPaths[ intCount ] ); 
                        } 
                        else 
                        { 
                            // If behind the the transistion should be in-active, 
                            // colour it with the active colour
                            e.Graphics.FillPath( new SolidBrush( _mActiveColour ), segmentPaths[ intCount ] ); 
                        } 
                    } 
                } 
                else 
                { 
                    // Draw all segments in in-active colour if not enabled
                    e.Graphics.FillPath( new SolidBrush( _mInactiveColour ), segmentPaths[ intCount ] ); 
                } 
            } 
        } 
        
        
        private void ProgressDisk_Resize( object sender, System.EventArgs e ) 
        { 
            CalculateSegments(); 
        } 
        
        
        private void ProgressDisk_SizeChanged( object sender, System.EventArgs e ) 
        { 
            
            CalculateSegments(); 
        } 
        
    }
}