﻿namespace SPC.Monitor.DrawBoards
{
    partial class SpectralDistributionDrawBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY3 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions3 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.StepAreaSeriesView stepAreaSeriesView5 = new DevExpress.XtraCharts.StepAreaSeriesView();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView5 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView6 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.StepAreaSeriesView stepAreaSeriesView6 = new DevExpress.XtraCharts.StepAreaSeriesView();
            this.chartControl1 = new SPC.Base.Control.AdvChartControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairOptions.HighlightPoints = false;
            xyDiagram3.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram3.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.EnableAxisXScrolling = true;
            xyDiagram3.EnableAxisXZooming = true;
            xyDiagram3.ScrollingOptions.UseKeyboard = false;
            xyDiagram3.ScrollingOptions.UseMouse = false;
            xyDiagram3.ScrollingOptions.UseTouchDevice = false;
            secondaryAxisY3.AxisID = 0;
            secondaryAxisY3.Name = "Secondary AxisY 1";
            secondaryAxisY3.VisibleInPanesSerializable = "-1";
            secondaryAxisY3.VisualRange.Auto = false;
            secondaryAxisY3.VisualRange.AutoSideMargins = false;
            secondaryAxisY3.VisualRange.MaxValueSerializable = "100";
            secondaryAxisY3.VisualRange.MinValueSerializable = "0";
            secondaryAxisY3.VisualRange.SideMarginsValue = 0D;
            secondaryAxisY3.WholeRange.Auto = false;
            secondaryAxisY3.WholeRange.AutoSideMargins = false;
            secondaryAxisY3.WholeRange.MaxValueSerializable = "100";
            secondaryAxisY3.WholeRange.MinValueSerializable = "0";
            secondaryAxisY3.WholeRange.SideMarginsValue = 0D;
            xyDiagram3.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY3});
            xyDiagram3.ZoomingOptions.UseMouseWheel = false;
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.RuntimeHitTesting = true;
            series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel3.Angle = 42;
            pointSeriesLabel3.Antialiasing = true;
            pointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            pointOptions3.PointView = DevExpress.XtraCharts.PointView.Argument;
            pointSeriesLabel3.PointOptions = pointOptions3;
            pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel3.TextOrientation = DevExpress.XtraCharts.TextOrientation.TopToBottom;
            series7.Label = pointSeriesLabel3;
            series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series7.Name = "Series 1";
            stepAreaSeriesView5.Transparency = ((byte)(0));
            series7.View = stepAreaSeriesView5;
            series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series8.Name = "Series 2";
            splineSeriesView5.AxisYName = "Secondary AxisY 1";
            series8.View = splineSeriesView5;
            series9.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series9.Name = "Series 3";
            splineSeriesView6.AxisYName = "Secondary AxisY 1";
            series9.View = splineSeriesView6;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7,
        series8,
        series9};
            stepAreaSeriesView6.MarkerOptions.Size = 8;
            this.chartControl1.SeriesTemplate.View = stepAreaSeriesView6;
            this.chartControl1.SideBySideEqualBarWidth = false;
            this.chartControl1.Size = new System.Drawing.Size(724, 377);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "显示X坐标";
            this.barEditItem1.Edit = this.repositoryItemCheckEdit1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemCheckEdit1_EditValueChanging);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1});
            this.barManager1.MaxItemId = 1;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(724, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 377);
            this.barDockControlBottom.Size = new System.Drawing.Size(724, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(724, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // SpectralDistributionDrawBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SpectralDistributionDrawBoard";
            this.Size = new System.Drawing.Size(724, 377);
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.Control.AdvChartControl chartControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
