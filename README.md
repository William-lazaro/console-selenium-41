# Console Selenium 41

Projeto desenvolvido para a atividade prática da disciplina **Gestão e Qualidade de Software**, utilizando C#, .NET 10, MSTest e Selenium WebDriver.

## Objetivo

Desenvolver uma solução de automação de testes para interagir com um formulário web, realizando preenchimentos, seleções e validações automatizadas.

Formulário utilizado: https://www.selenium.dev/selenium/web/web-form.html

## Tecnologias utilizadas

- C#
- .NET 10
- Selenium WebDriver
- Selenium Support
- MSTest
- Google Chrome
- Visual Studio Code

## Estrutura do projeto

```text
ConsoleSelenium41/
│
├── ConsoleSelenium/
│   └── ConsoleSelenium.csproj
│
├── ConsoleSelenium.Tests/
│   ├── WebFormularioDesafioTest.cs
│   └── ConsoleSelenium.Tests.csproj
│
├── ConsoleSelenium41.slnx
└── .gitignore
```

## Cenários automatizados

### Exercício 1 — Cadastro Completo

- Preenchimento do campo de texto com nome completo.
- Preenchimento do campo de senha.
- Preenchimento da área de texto.
- Validação do campo somente leitura.
- Envio do formulário e validação da mensagem de sucesso.

### Exercício 2 — Dropdowns e Datalist

- Seleção da opção Two utilizando SelectElement.
- Validação do valor selecionado.
- Preenchimento do campo Datalist com Seattle.
- Envio do formulário e validação do resultado.

### Exercício 3 — Checkboxes, Radios e Color Picker

- Verificação do primeiro checkbox.
- Seleção do segundo checkbox.
- Seleção do segundo botão de rádio.
- Alteração da cor utilizando o Color Picker.
- Envio do formulário e validação do resultado.

## Como executar o projeto

É necessário ter o .NET 10 SDK e o Google Chrome instalados.

1. Clone o repositório:

```bash
git clone https://github.com/William-lazaro/console-selenium-41.git
```

2. Entre na pasta:

```bash
cd console-selenium-41
```

3. Restaure as dependências:

```bash
dotnet restore
```

4. Execute os testes:

```bash
dotnet test
```

## Resultado dos testes

Os três cenários automatizados foram executados com sucesso.

**Resultado validado: 3 testes aprovados e nenhuma falha.**

## Autor

William Lázaro

Projeto acadêmico desenvolvido para a disciplina Gestão e Qualidade de Software.