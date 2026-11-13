
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConsoleSelenium.Tests;

[TestClass]
public class WebFormularioDesafioTest
{
    private IWebDriver driver = null!;

    [TestInitialize]
    public void Configurar()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [TestCleanup]
    public void Finalizar()
    {
        driver.Quit();
        driver.Dispose();
    }

    // EXERCÍCIO 1 - Cadastro Completo
    [TestMethod]
    public void CadastroCompleto_DeveExibirMensagemDeSucesso()
    {
        driver.Navigate().GoToUrl(
            "https://www.selenium.dev/selenium/web/web-form.html");

        driver.FindElement(By.Name("my-text"))
            .SendKeys("William Lazaro");

        driver.FindElement(By.Name("my-password"))
            .SendKeys("SenhaTeste123!");

        driver.FindElement(By.Name("my-textarea"))
            .SendKeys("Tenho experiência com testes automatizados utilizando C# e Selenium.");

        var campoReadonly = driver.FindElement(
            By.Name("my-readonly"));

        Assert.AreEqual(
            "Readonly input",
            campoReadonly.GetAttribute("value"));

        driver.FindElement(By.TagName("button")).Click();

        var espera = new WebDriverWait(
            driver, TimeSpan.FromSeconds(10));

        espera.Until(d => d.Url.Contains("submitted-form"));

        var mensagem = driver.FindElement(
            By.TagName("body")).Text;

        Assert.Contains(
    "Received!",
    mensagem,
    "A mensagem de sucesso não foi encontrada.");
    }

    // EXERCÍCIO 2 - Dropdowns e Datalist
    [TestMethod]
    public void DropdownEDatalist_DeveSelecionarOpcoesCorretamente()
    {
        driver.Navigate().GoToUrl(
            "https://www.selenium.dev/selenium/web/web-form.html");

        // Selecionar a opção Two
        var dropdown = new SelectElement(
            driver.FindElement(By.Name("my-select")));

        dropdown.SelectByText("Two");

        // Validar o valor selecionado
        Assert.AreEqual(
            "2",
            dropdown.SelectedOption.GetAttribute("value"));

        // Preencher o datalist
        var datalist = driver.FindElement(
            By.Name("my-datalist"));

        datalist.SendKeys("Seattle");

        // Enviar formulário
        driver.FindElement(By.TagName("button")).Click();

        var espera = new WebDriverWait(
            driver, TimeSpan.FromSeconds(10));

        espera.Until(d => d.Url.Contains("submitted-form"));

        var mensagem = driver.FindElement(
            By.TagName("body")).Text;

        Assert.Contains(
    "Received!",
    mensagem,
    "O formulário não foi enviado corretamente.");
    }

    // EXERCÍCIO 3 - Checkboxes, Radios e Color Picker
    [TestMethod]
    public void CheckboxesRadiosEColorPicker_DeveEnviarFormularioComSucesso()
    {
        driver.Navigate().GoToUrl(
            "https://www.selenium.dev/selenium/web/web-form.html");

        // Verificar se o primeiro checkbox está marcado
        var primeiroCheckbox = driver.FindElement(
            By.Id("my-check-1"));

        Assert.IsTrue(
            primeiroCheckbox.Selected,
            "O primeiro checkbox deveria estar marcado.");

        // Marcar o segundo checkbox
        var segundoCheckbox = driver.FindElement(
            By.Id("my-check-2"));

        segundoCheckbox.Click();

        Assert.IsTrue(
            segundoCheckbox.Selected,
            "O segundo checkbox não foi marcado.");

        // Selecionar o segundo botão de rádio
        var segundoRadio = driver.FindElement(
            By.Id("my-radio-2"));

        segundoRadio.Click();

        Assert.IsTrue(
            segundoRadio.Selected,
            "O segundo botão de rádio não foi selecionado.");

        // Alterar a cor do Color Picker
        var colorPicker = driver.FindElement(
            By.Name("my-colors"));

        colorPicker.SendKeys("#ff0000");

        Assert.AreEqual(
            "#ff0000",
            colorPicker.GetDomProperty("value"));

        // Enviar formulário
        driver.FindElement(By.TagName("button")).Click();

        var espera = new WebDriverWait(
            driver, TimeSpan.FromSeconds(10));

        espera.Until(d => d.Url.Contains("submitted-form"));

        var mensagem = driver.FindElement(
            By.TagName("body")).Text;

        Assert.Contains(
    "Received!",
    mensagem,
    "O formulário não foi enviado corretamente.");
    }
}
