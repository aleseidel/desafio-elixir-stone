Dev: ALEXANDRE RANGEL SEIDEL
E-mail: arseidel2003@gmail.com

- Desafio Elixir Stone -

### COMO RODAR O PROJETO ###

## VIA WINDOWS TERMINAL (UBUNTU) ## 

# É necessário instalar um compilador C# no bash. Sugiro o comando abaixo:

sudo apt install mono-mcs

# Após o término da instalação, os comandos abaixo irão compilar a solução e apresentar os resultados automáticamente.

mcs -out:Build.exe StoneChallenge.cs; mono Build.exe;

------------------------------------------------------

## VIA CMD MONO COMPILER ##

# É necessário instalar o compilador Mono via Link abaixo ou por um gerenciador de pacotes (Chocolatey)

LINK:
https://www.mono-project.com/download/stable/

CHOCOLATEY:
choco install mono

# Após instalar, ele irá criar um atalho no menu iniciar. Em seguida, é necessário abrir esse CMD e navegar até a pasta do desafio.

# Ao navegar até essa pasta, os comandos abaixo irão compilar a solução e apresentar os resultados automáticamente.

mcs StoneChallenge.cs

# O comando acima irá gerar um arquivo .exe. Para rodar esse arquivo, basta digitar o comando abaixo, continuando após o comando acima:

mono StoneChallenge.exe

------------------------------------------------------

### OBSERVAÇÃO ###

# Para alterar os resultados apresentados no console, é preciso alterar diretamente no arquivo "StoneChallenge.cs" 
# e seguir novamente os passos de compilação.

