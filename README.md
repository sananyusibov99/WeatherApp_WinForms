# Weather App (WinForms)

A desktop weather app for any city. I built it in August–September 2018 while studying C# at STEP IT Academy. Partway through I refactored it to the Model–View–Presenter (MVP) pattern.

## Features

- Detects your city by IP address, or lets you type one in
- Current weather: temperature, min/max, description, wind, clouds, pressure and humidity
- Forecasts for tomorrow, the next 5 days and every 3 hours for 5 days, browsed with Previous/Next buttons
- Units: Celsius, Fahrenheit or Kelvin
- A weather icon and a background image (clear, clouds, rain, snow, fog, thunder) that change with the conditions
- Interface and forecast text translated into the language chosen in Settings

## Tech stack

C#, Windows Forms, .NET Framework 4.6.1, Newtonsoft.Json; OpenWeatherMap API (weather), ipstack API (location), Yandex Translate API (translation)

## Architecture (MVP)

| Folder | Purpose |
|---|---|
| `Model/` | weather data, settings, languages |
| `View/` | main window and settings window |
| `Presenter/` | `WeatherPresenter` makes the API requests and fills the model |
| `Interfaces/` | contracts between the view and the presenter |
| `Services/` | translation and background selection |

## How to run

1. Open `WeatherApp.sln` in Visual Studio.
2. Restore NuGet packages.
3. Press F5.

## Status

This is a learning project from 2018 and is no longer maintained. The API keys in the code are old free keys from 2018. To run the app today, put your own OpenWeatherMap and ipstack keys in `Presenter/WeatherPresenter.cs`. Translation does not work because Yandex Translate API v1.5 has been shut down.
