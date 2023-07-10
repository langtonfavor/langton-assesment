# .NET 6 Project - JavaScript Alerts Test

This project demonstrates a test suite using Selenium WebDriver and NUnit for automating browser interactions with JavaScript alerts on the-internet.herokuapp.com.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Chrome browser (for ChromeDriver)

## Setup

1. Clone this repository or download the source code.
2. Install the necessary NuGet packages:
3. Make sure you have ChromeDriver installed and added to your system PATH.

## Running the Tests

1. Open a terminal and navigate to the project folder.
2. Run the following command to execute the tests:

3. The test results will be displayed in the terminal.

## Project Structure

- `JavaScriptAlerts.cs`: Contains the test methods for JavaScript alerts.
- `Program.cs`: Entry point for running the tests.

## Test Scenarios

The test suite includes the following test scenarios:

1. **AcceptAlert()**
- Opens Chrome and navigates to https://the-internet.herokuapp.com/javascript_alerts.
- Clicks the "Click for JS Alert" button to trigger an alert.
- Switches to the alert and accepts it.
- Verifies that the result text is correct.

2. **DismissAlert()**
- Opens Chrome and navigates to https://the-internet.herokuapp.com/javascript_alerts.
- Clicks the "Click for JS Confirm" button to trigger a confirm dialog.
- Switches to the confirm dialog and dismisses it.
- Verifies that the result text is correct.

3. **EnterTextInPrompt()**
- Opens Chrome and navigates to https://the-internet.herokuapp.com/javascript_alerts.
- Clicks the "Click for JS Prompt" button to trigger a prompt dialog.
- Switches to the prompt dialog, enters text "Entering Text in Prompt," and accepts it.
- Verifies that the result text is correct.

## Technologies Used

- .NET 6
- Selenium WebDriver
- NUnit

## Resources

- [Selenium WebDriver Documentation](https://www.selenium.dev/documentation/en/webdriver/)
- [NUnit Documentation](https://docs.nunit.org/)
- [ChromeDriver - WebDriver for Chrome](https://sites.google.com/a/chromium.org/chromedriver/)

## License

This project is licensed under the [MIT License](LICENSE).

