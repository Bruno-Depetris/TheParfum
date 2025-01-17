using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheParfum.APIs.Logicas;
using TheParfum.APIs.Modelos;

namespace TheParfum.Formularios {
    public partial class DashBoard : Form {
        public DashBoard() {
            InitializeComponent();
            comboBoxEdit_Seleccionar.Items.Insert(0, "Seleccionar un MERCADO");
            comboBoxEdit_Seleccionar.Items.Insert(1, "Blue");
            comboBoxEdit_Seleccionar.Items.Insert(2, "Bolsa");
            comboBoxEdit_Seleccionar.Items.Insert(3, "Contado");
            comboBoxEdit_Seleccionar.Items.Insert(4, "Mayorista");
            comboBoxEdit_Seleccionar.Items.Insert(5, "Cripto");
            comboBoxEdit_Seleccionar.Items.Insert(6, "Tarjeta");


            comboBoxEdit_Seleccionar.SelectedIndex = 0;
        }


        private async void comboBoxEdit_Seleccionar_SelectedIndexChanged(object sender, EventArgs e) {
            string urlApi = "https://dolarapi.com/v1/dolares";


            using (var apiHelper = new ApiCotizacion(urlApi)) {
                try {
                    string responce = await apiHelper.GetAsync(urlApi);


                    List<ModeloApiCotizacion> apicotizacion = JsonConvert.DeserializeObject<List<ModeloApiCotizacion>>(responce);
                    var casaSeleccionada = " ";

                    switch (comboBoxEdit_Seleccionar.SelectedIndex) {

                        case 1:
                            casaSeleccionada = "blue";
                            break;
                        case 2:
                            casaSeleccionada = "bolsa";
                            break;
                        case 3:
                            casaSeleccionada = "contadoconliqui";
                            break;
                        case 4:
                            casaSeleccionada = "mayorista";
                            break;
                        case 5:
                            casaSeleccionada = "crypto";
                            break;
                        case 6:
                            casaSeleccionada = "tarjeta";
                            break;
                    }

     
                    var cotizacionFiltrada = apicotizacion.Where(c => c.Casa == casaSeleccionada);

                    foreach (var cotizacion in cotizacionFiltrada) {
                        poisonLabel_Moneda.Text = cotizacion.Moneda;
                        poisonLabel_Casa.Text = cotizacion.Casa;
                        poisonLabel_Compra.Text = cotizacion.Compra.ToString();
                        poisonLabel_Venta.Text = cotizacion.Venta.ToString();
                        poisonLabel_Actualizacion.Text = cotizacion.FechaActualizacion.ToString();
                    }
                } catch (HttpRequestException httpex) {
                    throw httpex;


                } catch (Exception ex) {
                    throw ex;
                }




            }
           
        }

        private async void DashBoard_Load(object sender, EventArgs e) {
            string urlApi = "https://dolarapi.com/v1/dolares";


            using (var apiHelper = new ApiCotizacion(urlApi)) {
                try {
                    string responce = await apiHelper.GetAsync(urlApi);


                    List<ModeloApiCotizacion> apicotizacion = JsonConvert.DeserializeObject<List<ModeloApiCotizacion>>(responce);
                    var casaSeleccionada = "blue";

              
                    var cotizacionFiltrada = apicotizacion.Where(c => c.Casa == casaSeleccionada);

                    foreach (var cotizacion in cotizacionFiltrada) {
                        poisonLabel_Moneda.Text = cotizacion.Moneda;
                        poisonLabel_Casa.Text = cotizacion.Casa;
                        poisonLabel_Compra.Text = cotizacion.Compra.ToString();
                        poisonLabel_Venta.Text = cotizacion.Venta.ToString();
                        poisonLabel_Actualizacion.Text = cotizacion.FechaActualizacion.ToString();
                    }





                } catch (HttpRequestException httpex) {
                    throw httpex;


                } catch (Exception ex) {
                    throw ex;
                }




            }
        }
    }
}
