using System.Configuration;
using System.Data;
using System.Windows;

/*

        <Grid>
            <Grid.ColumnDefinitions>
                <!-- Première colonne pour le premier rectangle -->
                <ColumnDefinition Width="100" />
                <!-- Deuxième colonne pour le second rectangle -->
                <ColumnDefinition Width="100" />
            </Grid.ColumnDefinitions>

            <!-- Premier rectangle -->
            <Rectangle Fill="#0D1B2A" Grid.Column="0" VerticalAlignment="Stretch" />

            <!-- Deuxième rectangle -->
            <Grid x:Name="sub_navigation" Grid.Column="1" VerticalAlignment="Stretch">
                <Rectangle Fill="#415A77" />
                <Rectangle Stroke="Black" Margin="0,0,0,630" />
                <Rectangle Fill="#1B263B" Margin="0,644,0,0" />
            </Grid>
        </Grid>

//Old
<Grid HorizontalAlignment="Left" VerticalAlignment="Stretch" Width="80">
            <Rectangle Fill="#0D1B2A"/>
        </Grid>

        <!-- Sub Navigation -->
        <Grid x:Name="sub_navigation" VerticalAlignment="Center" Height="704" Margin="100,0,886,0">
            <Rectangle Fill="#415A77"/>
            <Rectangle Stroke="Black" Margin="0,0,0,630"/>
            <Rectangle Fill="#1B263B" Margin="0,644,0,0"/>
        </Grid>

*/
namespace discord_like
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }

}
