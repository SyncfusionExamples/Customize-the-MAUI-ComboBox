# Customize-the-MAUI-ComboBox

This sample demonstrates how to customize the MAUI ComboBox control within a .NET MAUI application. You'll also see how to display messages in the input field, personalize the drop-down and clear icon, position the drop-down menu above the input field, and customize the items in the drop-down menu.

## Sample

```xaml
<comboBox:SfComboBox ItemsSource="{Binding Employees}"
                     DisplayMemberPath="Name"
                     TextMemberPath="Name"
                     WidthRequest="280"
                     HeightRequest="50"
                     Placeholder="Select an employee">
    <comboBox:SfComboBox.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <Grid Margin="{OnPlatform Default='0,2', Android='0,5'}"
                  VerticalOptions="Center"
                  HorizontalOptions="Center"
                  ColumnDefinitions="48,220">
                    <Image Grid.Column="0"
                           HorizontalOptions="Center"
                           VerticalOptions="Center"
                           Source="{Binding ProfilePicture}"/>
                    <StackLayout HorizontalOptions="Start"
                                 VerticalOptions="Center"
                                 Grid.Column="1"
                                 Margin="15,0,0,0">
                        <Label HorizontalTextAlignment="Start"
                               VerticalTextAlignment="Center"
                               FontSize="14"
                               Text="{Binding Name}"/>
                        <Label HorizontalOptions="Start"
                               VerticalTextAlignment="Center"
                               Opacity=".54"
                               FontSize="12"
                               Text="{Binding Designation}"/>
                    </StackLayout>
                </Grid>
            </ViewCell>
        </DataTemplate>
    </comboBox:SfComboBox.ItemTemplate>
</comboBox:SfComboBox>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
