using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui;

// Corrigir: Substituir MauiAppCompatActivity por MauiAppCompatActivity (namespace correto: Microsoft.Maui.ApplicationModel)
// Correção: O tipo correto é Microsoft.Maui.MauiAppCompatActivity, mas normalmente está em Microsoft.Maui, não Microsoft.Maui.ApplicationModel.
// Certifique-se de que o pacote NuGet Microsoft.Maui está instalado.
// Se o tipo não for encontrado, tente usar Microsoft.Maui.MauiAppCompatActivity.

namespace PrevisaoTempo
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : Microsoft.Maui.MauiAppCompatActivity
    {
    }
}
