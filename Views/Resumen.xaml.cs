namespace hFonsecaExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario,
            string xNombre,
            string xApellido,
            string xEdad,
            string xFecha,
            string xCiudad,
            string xPaís,
            string xMontoInicial,
            string xPagomensual,
            string xPagoTotal)
	{
		InitializeComponent();
        lblUsuario2.Text = "Usuario Conectado: " + usuario;

        lblNombre2.Text = xNombre;
        lblApellido2.Text= xApellido;
        lblEdad2.Text= xEdad;
        lblFecha2.Text= xFecha;
        lblCiudad2.Text= xCiudad;
        lblPais2.Text= xPaís;
        lblMontoInicial2.Text= xMontoInicial;
        lblPagoMensual2.Text= xPagomensual;
        lblPagoTotal2.Text= xPagoTotal;



    }



}