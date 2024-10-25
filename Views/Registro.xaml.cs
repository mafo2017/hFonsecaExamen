namespace hFonsecaExamen.Views;

public partial class Registro : ContentPage
{
    string usuario_global = "";

    string xNombre = "";
    string xApellido = "";
    string xEdad = "";
    string xFecha = "";
    string xCiudad = "";
    string xPaís = "";
    string xMontoInicial = "";
    string xPagomensual = "";
    string xPagoTotal = "";

    public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: "+ usuario;
        usuario_global = usuario;
	}

    private void pkPaises_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void pkCiudades_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dpFecha_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
    {

        if (string.IsNullOrWhiteSpace(txtMontoInicial.Text))
        {
            DisplayAlert("Error", "El monto inicial debe estar entre 1 y 1499", "OK");
            return;

        }

        var valorMontoInicial = Int32.Parse(txtMontoInicial.Text);

        var saldo = 1500 - valorMontoInicial;

        var interes = 1500 * 0.04;  // interes = 60

        var mensual = (saldo / 4) + interes;

        var total = valorMontoInicial + (4 * mensual);

        string fecha = dpFecha.ToString();

        xFecha = fecha;


        if (valorMontoInicial <= 0 || valorMontoInicial > 1499)
        {
            DisplayAlert("Error", "El monto inicial debe estar entre 1 y 1499", "OK");
            return;
        }

        txtCalcularPagoMensual.Text = mensual.ToString();

        xPagomensual = mensual.ToString();
        xPagoTotal = total.ToString();

    }

    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtApellido.Text) ||
            string.IsNullOrWhiteSpace(txtEdad.Text))
        {
            DisplayAlert("Error", "Ingrese Nombre/Apellido/Edad", "OK");
            return;
        }

        string xNombre = txtNombre.Text;
        string xApellido = txtApellido.Text;
        string xEdad = txtEdad.Text;
          
        string xCiudad = pkCiudades.ToString();
        string xPaís = pkPaises.ToString();
        string xMontoInicial = txtMontoInicial.Text;
        
        Navigation.PushAsync(new Views.Resumen(usuario_global, xNombre, xApellido, xEdad, xFecha, xCiudad, xPaís, xMontoInicial,xPagomensual, xPagoTotal));

    }
}