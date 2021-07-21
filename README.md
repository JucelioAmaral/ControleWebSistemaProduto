
# Projeto Controle Web Sistema de Produtos

Sistema ASP NET (C#) - Programação em Camadas - CRUD completo, Compreendendo aplicação de técnicas de programação em camadas, usando ASP dot net com C#,  utilizando a biblioteca do MySQL Connector/NET no Visual Studio, implementando um CRUD completo para gestão de estoques.

## Pré requisitos
 
Para executar este sistema você precisa baixar e instalar os softwares listados ou os mais novos possíveis. Pode seguir a sequência dos links e ao concluir todas as instalações, sugiro que reinicie seu computador ou notebook.

1. [Visual Studio](https://www.visualstudio.com/pt-br/free-developer-offers/)
2. [MySQL](https://www.mysql.com/products/workbench/)
3. [XAMPP](https://www.apachefriends.org/pt_br/index.html)
4. [MySQL para Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/)
5. [MySQL Connector](https://dev.mysql.com/downloads/connector/net/6.9.html)


## Como baixar o código

git clone https://github.com/JucelioAmaral/ControleWebSistemaProduto.git

## Como configurar o sistema?

1. Abrir a Visual Studio;
2. Defina o Index.aspx como "Definir como pagina inicial" ou selecione ele e execute com ele selecionado;
3. Executar o script do arquivo: script_bd_estoque.sql;
4. Execute o xampp, o Apache e o MySQL;
5. Verifique o banco de dados MySQL workbench com o banco estoque e as duas tabelas;
6. Executar o sistema pelo debug, pelo "ISS Express...".

**O sistema pode ser testado pelo link: http://localhost:49897/Index.aspx**

## Em caso de erro

1. Erro "Server Error in '/' Application.": Referente ao "add assembly="MySql.Data, Version=" (<add assembly="MySql.Data, Version=8.0.25.0, Culture=neutral, PublicKeyToken=C5687FC88969C44D"/>). Verifique a versão do "MySQL Connector Net" em Program and Features (programas instalados) do windows e mude o "Version" no arquivo "Web.Config" para a que está instalada/ a mais nova.
Projeto não executa corretamente devido a versão do conector do Dot NET. Atualize a versão. Nesse caso abaixo, de 6.9.12 para 8.0.25.
	        
			<add assembly="MySql.Data, Version=8.0.25.0, Culture=neutral, PublicKeyToken=C5687FC88969C44D"/>

