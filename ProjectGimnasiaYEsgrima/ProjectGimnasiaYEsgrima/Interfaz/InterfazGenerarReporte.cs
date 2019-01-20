using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazGenerarReporte : Form
    {
        ReportDataSource MiLista;
        string MiDir;
        public InterfazGenerarReporte(ReportDataSource lista,string dir)
        {
            MiLista = lista;
            MiDir = dir;
            InitializeComponent();
            
        }

        private void InterfazGenerarReporte_Load(object sender, EventArgs e)
        {
            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = MiDir;
            reportViewer1.LocalReport.DataSources.Add(MiLista);

            reportViewer1.RefreshReport();
        }
    }
}
