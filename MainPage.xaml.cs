
//using Android.Media;
using Plugin.Maui.Audio;

namespace App_som;



public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;

    

	public MainPage(IAudioManager audioManager)
	{
		InitializeComponent();
        this.audioManager = audioManager;

        
    }
    


    private async void bateria1_Clicked(object sender, EventArgs e)
    {
        var bat1 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("bat1.wav"));
        bat1.Play();

        bateria1.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void bateria2_Clicked(object sender, EventArgs e)
    {
        var bat2 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("bat2.wav"));
        bat2.Play();

        bateria2.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void bateria3_Clicked(object sender, EventArgs e)
    {
        var bat3 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("bat3.wav"));
        bat3.Play();

        bateria3.BackgroundColor = Color.FromArgb("#DCDCDC");

    }

    private async void bateria4_Clicked(object sender, EventArgs e)
    {
        var bat4 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("bat4.wav"));
        bat4.Play();

        bateria4.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void bateria5_Clicked(object sender, EventArgs e)
    {
        var bat5 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("bat5.wav"));
        bat5.Play();

        bateria5.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void guitarra1_Clicked(object sender, EventArgs e)
    {
        var guitar1 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("guitarra.wav"));
        guitar1.Play();

        guitarra1.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void guitarra2_Clicked(object sender, EventArgs e)
    {
        var guitar2 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("guitarra2.wav"));
        guitar2.Play();

        guitarra2.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void guitarra3_Clicked(object sender, EventArgs e)
    {
        var guitar3 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("guitarra3.wav"));
        guitar3.Play();

        guitarra3.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void violao_Clicked(object sender, EventArgs e)
    {
        var violao1 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("violao.wav"));
        violao1.Play();

        violao.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void piano1_Clicked(object sender, EventArgs e)
    {
        var pian1 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("piano.wav"));
        pian1.Play();

        piano1.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void piano2_Clicked(object sender, EventArgs e)
    {
        var pian2 = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("piano2.wav"));
        pian2.Play();

        piano2.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void heroico_Clicked(object sender, EventArgs e)
    {
        var heroi = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("heroico.wav"));
        heroi.Play();

        heroico.BackgroundColor = Color.FromArgb("#DCDCDC");
    }

    private async void Yeah_Clicked(object sender, EventArgs e)
    {
        var yea = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("yeah.wav"));
        yea.Play();

        Yeah.BackgroundColor = Color.FromArgb("#DCDCDC");
    }
}

