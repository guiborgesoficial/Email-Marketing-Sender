# Email-Marketing-Sender
This project is responsible for carrying out mass emailing for Email Marketing practice. Because it is not a robust solution, it becomes an interesting feature to be implemented in even larger projects, such as a customer management system or a gym management system. In this way, the manager can integrate this solution to send e-mails to customers informing notices about invoices and voucher, for example.

# Environment
The project consists of a C # Windows Forms application.

# Settings
After cloning this project in your development environment, some initial configurations will be necessary for the program to run without errors.

## Connection String
In the Classes folder in Conexão.cs on the 13 line you will have to change the connection string (sqlConnection) to point to your SQL Server Database. Here is an example:

```C#
public SqlConnection sqlConnection = new SqlConnection (@ "ADD YOUR CONNECTION STRING");
```
## Database
In order for the "LISTA" button (btn_lista) to import the email list correctly, it will be necessary to create a Table in your SQL Server with the name "ListaEmails" containing the fields "NOME" and "EMAIL" in varchar format. See the SCRIPT for creating the table below:

```SQL
CREATE TABLE [dbo]. [ListaEmails] (
[NOME] [varchar] (50) NOT NULL,
[EMAIL] [varchar] (80) NOT NULL
) ON [PRIMARY]
GO
```
Note the DataBase where this Table is inserted correctly in the connection string (sqlConnection).

## Email Server
In order for emails to be delivered correctly to recipients, it is necessary to pay attention to the "PORTA" and "SMTP" parameters that vary according to the email service used.

The project is configured to send e-mails where the linked account is part of Office, which includes the Outlook service.
It is also necessary to check the daily limit that your email provider offers, so that it does not exceed the limit and the package is successfully delivered to the recipient.
Below I will leave some "PORTA" and "SMTP" settings for the most used email services:

#### HOTMAIL
1. SMTP Hotmail server name: smtp.live.com
2. SMTP Hotmail User (Email): your Hotmail account
3. SMTP Hotmail Password (Password): your Hotmail password
4. SMTP Hotmail port: 25 or 465 or 587

#### GMAIL
1. SMTP Gmail server name: smtp.gmail.com
2. SMTP Gmail User (Email): your Gmail address
3. Gmail SMTP Password (Password): your Gmail password
4. SMTP Gmail port: 465 or 587 or 587

#### YAHOO
1. Yahoo SMTP server address: smtp.mail.yahoo.com
2. Yahoo SMTP User (Email): your Yahoo Mail account
3. Yahoo SMTP Password (Password): your Yahoo Mail password
4. Yahoo SMTP port: 465

#### UOL
1. UOL SMTP server address: smtps.uol.com.br
2. UOL SMTP User (Email): your UOL Mail account
3. UOL SMTP Password (Password): your UOL Mail password
4. UOL SMTP port: 587

# Versão em Português

# Email-Marketing-Sender
Este projeto é responsável por realizar envios de emails em massa para prática de Email Marketing. Por não ser uma solução robusta, ela se torna uma funcionalidade interessante para ser implementada em projetos ainda maiores, como um sistema gestor de clientes ou um sistema de gerenciamento de academia. Desta forma o gestor poderá integrar esta solução para enviar e-mails aos clientes informando avisos sobre faturas e vencimentos, por exemplo.

# Ambiente
O projeto consiste em uma aplicação C# Windows Forms.

# Configurações
Após clonar esse projeto em seu ambiente de desenvolvimento, será necessário algumas configurações iniciais para que a execução do programa seja efetuada sem erros.

## String de Conexão
Na pasta Classes em Conexão.cs na 13ª você terá que alterar a string de conexão (sqlConnection) para apontar para o seu Banco de Dados SQL Server. Segue o exemplo:

```C#
public SqlConnection sqlConnection = new SqlConnection(@"ADICIONAR SUA STRING DE CONEXÃO");
```
## Banco de Dados
Para que o botão "LISTA" (btn_lista) importe a lista de e-mails corretamente, será necessário criar uma Tabela no seu SQL Server com o nome "ListaEmails" contendo os campos "NOME" e "EMAIL" no formato varchar. Veja o SCRIPT de criação da tabela abaixo:

```SQL
CREATE TABLE [dbo].[ListaEmails](
	[NOME] [varchar](50) NOT NULL,
	[EMAIL] [varchar](80) NOT NULL
) ON [PRIMARY]
GO
```
Atente-se de apontar o Banco onde esta Tabela está inserida corretamente na string de conexão (sqlConnection).

## Servidor de Email
Para que os e-mails sejam entregues corrretamente aos destinatários é necessário se atentar aos parâmetros "PORTA" e "SMTP" que variam de acordo com o serviço de email usado.

O projeto está configurado para realizar o envio de e-mails onde a conta vinculada faz parte do Office, o que inclui o serviço Outlook.
É necessário também, verificar o limite diário que o seu provedor de e-mails oferta, para que não exceda o limite e o pacote seja entregue com sucesso ao distinatário.
Abaixo deixarei algumas configurações de "PORTA" e "SMTP" para os serviços de email mais utilizados:

#### HOTMAIL
1. Nome do servidor SMTP Hotmail: smtp.live.com
2. Usuario SMTP Hotmail(Email): a sua conta Hotmail
3. Password SMTP Hotmail(Senha): a sua password do Hotmail
4. Porta SMTP Hotmail: 25 ou 465 ou 587 

#### GMAIL
1. Nome do servidor SMTP Gmail: smtp.gmail.com
2. Usuario SMTP Gmail(Email): o seu endereço Gmail
3. Password SMTP Gmail(Senha): a sua password do Gmail
4. Porta SMTP Gmail: 465 ou 587 ou 587 

#### YAHOO
1. Endereço do servidor SMTP Yahoo: smtp.mail.yahoo.com
2. Usuario SMTP Yahoo(Email): a sua conta Yahoo Mail
3. Password SMTP Yahoo(Senha): a sua password do Yahoo Mail
4. Porta SMTP Yahoo: 465

#### UOL
1. Endereço do servidor SMTP UOL: smtps.uol.com.br
2. Usuario SMTP UOL(Email): a sua conta UOL Mail
3. Password SMTP UOL(Senha): a sua password do UOL Mail
4. Porta SMTP UOL: 587
