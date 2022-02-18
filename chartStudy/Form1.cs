using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chartStudy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//요소 초기화
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			btnAddXY_Click(sender, e);
			btnAddY_Click(sender, e);
		}
		//버튼

		private void btnAddY_Click(object sender, EventArgs e)
		{
			chartA.Series["Series1"].Points.Clear(); // 저장된값 지우기
			chartA.Series["Series1"].Points.Add(100);  // X=1
			chartA.Series["Series1"].Points.Add(200);  // X=2
			chartA.Series["Series1"].Points.Add(300);  // X=3
			chartA.Series["Series1"].Points.Add(400);  // X=4
		}

		private void btnAddXY_Click(object sender, EventArgs e)
		{
			chartB.Series[0].ChartType = SeriesChartType.Pie; //시리즈 차트타입을 파이타입으로A
			chartB.Series["Series1"].Points.Clear(); // 저장된값 지우기
			chartB.Series["Series1"].Points.AddXY(10, 100); // X=10, Y=100
			chartB.Series["Series1"].Points.AddXY(20, 200); // X=20, Y=200
			chartB.Series["Series1"].Points.AddXY(30, 300); // X=30, Y=300
			chartB.Series["Series1"].Points.AddXY(40, 400); // X=40, Y=400

			chartC.Series[0].ChartType = SeriesChartType.Line; //시리즈 차트타입을 선형타입으로
			chartC.Series["Series1"].Points.Clear();
			chartC.Series["Series1"].Points.AddXY(10, 100);
			chartC.Series["Series1"].Points.AddXY(20, 200);
			chartC.Series["Series1"].Points.AddXY(30, 300);
			chartC.Series["Series1"].Points.AddXY(40, 400);

			chartD.Series[0].ChartType = SeriesChartType.Bar; //시리즈 차트타입을 바타입으로
			chartD.Series["Series1"].Points.Clear();
			chartD.Series["Series1"].Points.AddXY(10, 100);
			chartD.Series["Series1"].Points.AddXY(20, 200);
			chartD.Series["Series1"].Points.AddXY(30, 300);
			chartD.Series["Series1"].Points.AddXY(40, 400);

			chartE.Series[0].ChartType = SeriesChartType.SplineArea; //시리즈 차트타입을 스플라인타입으로
			chartE.Series["Series1"].Points.Clear();
			chartE.Series[0].Points.AddXY(10, 100);
			chartE.Series[0].Points.AddXY(20, 500);
			chartE.Series[0].Points.AddXY(30, 300);
			chartE.Series[0].Points.AddXY(40, 400);
		}
	}
}
