using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    public partial class frmBdOperaciones : Form
    {
        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        public frmBdOperaciones()
        {
            InitializeComponent();
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                            "FROM (select * from libro where idIdioma > 1) as X  " +
                            "WHERE IDPAIS = 2";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, NOMBRE " +
                            "FROM LIBRO INNER JOIN PAIS " +
                            "on LIBRO.IDPAIS = PAIS.IDPAIS;";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                            "where idIdioma = 2 and " +
                            "idLibro in (Select idLibro from libro where idPais = 3)";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                            "where idIdioma = 2 and " +
                            "idLibro not in " +
                            "(Select idLibro from libro where idPais = 3) " +
                            "order by 1 asc";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +                // Espacio después del *
                            "FROM LIBRO " +             // Espacio después de LIBRO
                            "WHERE IDIDIOMA = 1 " +     // Espacio después del 1
                            "UNION " +                  // Espacio después de UNION
                            "SELECT * " +                // Espacio después del *
                            "FROM LIBRO " +             // Espacio después de LIBRO
                            "WHERE IDIDIOMA = 2;";

            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {

            String varSQL = "SELECT [TITULO] FROM [LIBRO] ORDER BY 1 DESC;";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT [TITULO], [AÑO] FROM [LIBRO] ORDER BY 1 DESC;";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                            "FROM LIBRO " +
                            "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                            "FROM LIBRO " +
                            "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }
    }
}
