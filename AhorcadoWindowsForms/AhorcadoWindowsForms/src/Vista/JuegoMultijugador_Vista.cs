using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhorcadoWindowsForms.src.Modelo;
using AhorcadoWindowsForms.src.Controlador;

namespace AhorcadoWindowsForms.src.Vista
{
    class JuegoMultijugador_Vista
    {
        #region Atributos

        Form1 pantallaPrincipal;
        JuegoMultijugador_Controlador controlador;

        List<PartidaMultijugador> partidasMultijugador;
        List<Panel> paneles;

        #endregion

        #region Constructor

        public JuegoMultijugador_Vista(Form1 pantallaPrincipal, List<ParametrosPartidaMultijugador> parametrosPartidaMultijugador)
        {
            this.pantallaPrincipal = pantallaPrincipal;
            controlador = new JuegoMultijugador_Controlador();

            partidasMultijugador = new List<PartidaMultijugador>();
            paneles = new List<Panel>();

            foreach (ParametrosPartidaMultijugador parametros in parametrosPartidaMultijugador)
            {
                PartidaMultijugador partida = new PartidaMultijugador();
                partida = controlador.CrearPartidaMultijugador(parametros);
                partidasMultijugador.Add(partida);

                Panel panel = new Panel();
                panel = CrearPanel(partida);
                paneles.Add(panel);
            }



        }

        #endregion
        private Panel CrearPanel(PartidaMultijugador partida)
        {
            #region Controles



            #endregion


            //
            // Panel
            //
            Panel panel = new Panel();

            switch (partidasMultijugador.Count)
            {
                case 1:
                    panel.Location = new System.Drawing.Point(12, 111);
                    break;
                case 2:
                    panel.Location = new System.Drawing.Point(610, 111);
                    break;
                case 3:
                    panel.Location = new System.Drawing.Point(12, 389);
                    break;
                case 4:
                    panel.Location = new System.Drawing.Point(610, 389);
                    break;
            }
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Size = new System.Drawing.Size(578, 261);
            pantallaPrincipal.Controls.Add(panel);

            return panel;
        }

        private void BloquearPanelesIniciales()
        {

        }
        
    }
}
