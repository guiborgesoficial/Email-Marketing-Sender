# Email-Marketing-Sender
Este projeto é responsável por realizar envios de emails em massa para prática de Email Marketing.

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
