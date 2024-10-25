namespace hFonsecaExamen.Views;

public partial class Login : ContentPage
{
    string user, password;

    string[,] credenciales = new string[2, 2]
    {
        { "estudiante", "moviles" },
        { "uisrael", "2024" }
    };

  
    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
    {
        InitializeComponent();

        user = usuario;
        password = contrasena;
    }


    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtClave.Text;
        bool autorizado=false;

        // Validar credenciales
        for (int i = 0; i<=1;i++ )
        {
            if (credenciales[i,0] == usuario && credenciales[i,1]==contrasena)
            {
                autorizado = true;
                break;
            }
        }

        if (autorizado)
        {
            // Navegar a la pantalla de Registro
            Navigation.PushAsync(new Views.Registro(usuario));
        }
        else
        {
            // Mostrar mensaje de error
            DisplayAlert("Error", "Usuario/Contraseña incorrectos", "OK");
        }


    }
}