namespace chartStudy
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnAddY = new System.Windows.Forms.Button();
			this.btnAddXY = new System.Windows.Forms.Button();
			this.chartC = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartE = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartE)).BeginInit();
			this.SuspendLayout();
			// 
			// chartA
			// 
			chartArea6.Name = "ChartArea1";
			this.chartA.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.chartA.Legends.Add(legend6);
			this.chartA.Location = new System.Drawing.Point(0, 29);
			this.chartA.Name = "chartA";
			series6.ChartArea = "ChartArea1";
			series6.Legend = "Legend1";
			series6.Name = "Series1";
			this.chartA.Series.Add(series6);
			this.chartA.Size = new System.Drawing.Size(301, 193);
			this.chartA.TabIndex = 0;
			this.chartA.Text = "chartA";
			// 
			// chartB
			// 
			chartArea7.Name = "ChartArea1";
			this.chartB.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.chartB.Legends.Add(legend7);
			this.chartB.Location = new System.Drawing.Point(0, 253);
			this.chartB.Name = "chartB";
			series7.ChartArea = "ChartArea1";
			series7.Legend = "Legend1";
			series7.Name = "Series1";
			this.chartB.Series.Add(series7);
			this.chartB.Size = new System.Drawing.Size(300, 193);
			this.chartB.TabIndex = 1;
			this.chartB.Text = "chartB";
			// 
			// btnAddY
			// 
			this.btnAddY.Location = new System.Drawing.Point(0, 0);
			this.btnAddY.Name = "btnAddY";
			this.btnAddY.Size = new System.Drawing.Size(75, 23);
			this.btnAddY.TabIndex = 2;
			this.btnAddY.Text = "btnAddY";
			this.btnAddY.UseVisualStyleBackColor = true;
			this.btnAddY.Click += new System.EventHandler(this.btnAddY_Click);
			// 
			// btnAddXY
			// 
			this.btnAddXY.Location = new System.Drawing.Point(0, 224);
			this.btnAddXY.Name = "btnAddXY";
			this.btnAddXY.Size = new System.Drawing.Size(75, 23);
			this.btnAddXY.TabIndex = 3;
			this.btnAddXY.Text = "btnAddXY";
			this.btnAddXY.UseVisualStyleBackColor = true;
			this.btnAddXY.Click += new System.EventHandler(this.btnAddXY_Click);
			// 
			// chartC
			// 
			chartArea8.Name = "ChartArea1";
			this.chartC.ChartAreas.Add(chartArea8);
			legend8.Name = "Legend1";
			this.chartC.Legends.Add(legend8);
			this.chartC.Location = new System.Drawing.Point(306, 253);
			this.chartC.Name = "chartC";
			series8.ChartArea = "ChartArea1";
			series8.Legend = "Legend1";
			series8.Name = "Series1";
			this.chartC.Series.Add(series8);
			this.chartC.Size = new System.Drawing.Size(300, 193);
			this.chartC.TabIndex = 4;
			this.chartC.Text = "chart1";
			// 
			// chartD
			// 
			chartArea9.Name = "ChartArea1";
			this.chartD.ChartAreas.Add(chartArea9);
			legend9.Name = "Legend1";
			this.chartD.Legends.Add(legend9);
			this.chartD.Location = new System.Drawing.Point(612, 253);
			this.chartD.Name = "chartD";
			series9.ChartArea = "ChartArea1";
			series9.Legend = "Legend1";
			series9.Name = "Series1";
			this.chartD.Series.Add(series9);
			this.chartD.Size = new System.Drawing.Size(300, 193);
			this.chartD.TabIndex = 5;
			this.chartD.Text = "chart2";
			// 
			// chartE
			// 
			chartArea10.Name = "ChartArea1";
			this.chartE.ChartAreas.Add(chartArea10);
			legend10.Name = "Legend1";
			this.chartE.Legends.Add(legend10);
			this.chartE.Location = new System.Drawing.Point(918, 253);
			this.chartE.Name = "chartE";
			series10.ChartArea = "ChartArea1";
			series10.Legend = "Legend1";
			series10.Name = "Series1";
			this.chartE.Series.Add(series10);
			this.chartE.Size = new System.Drawing.Size(300, 193);
			this.chartE.TabIndex = 6;
			this.chartE.Text = "chart3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1255, 689);
			this.Controls.Add(this.chartE);
			this.Controls.Add(this.chartD);
			this.Controls.Add(this.chartC);
			this.Controls.Add(this.btnAddXY);
			this.Controls.Add(this.btnAddY);
			this.Controls.Add(this.chartB);
			this.Controls.Add(this.chartA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartE)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
		private System.Windows.Forms.Button btnAddY;
		private System.Windows.Forms.Button btnAddXY;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartC;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartE;
	}
}

