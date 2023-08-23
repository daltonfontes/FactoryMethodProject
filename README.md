# Padr�o Factory em C#

O padr�o Factory � um padr�o de projeto de cria��o que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses escolham os tipos de objetos a serem criados. Isso abstrai o processo de cria��o de objetos e facilita a manuten��o e extensibilidade do c�digo.

## Implementa��o

Neste exemplo em C#, demonstramos a implementa��o do padr�o Factory com um cen�rio de cria��o de produtos e criadores concretos.

### Classes de Produtos

- `ConcreteProductA` e `ConcreteProductB` s�o classes concretas que implementam a interface `IProduct`. Elas representam diferentes tipos de produtos que podem ser criados.

### Classes de Criadores

- `Creator` � a classe abstrata base para os criadores concretos. Ela define o m�todo abstrato `CreateProduct()`, que ser� implementado pelas subclasses.

- `ConcreteCreatorA` e `ConcreteCreatorB` s�o as subclasses de criadores concretos. Elas estendem `Creator` e implementam o m�todo `CreateProduct()` para criar inst�ncias dos produtos correspondentes.

### Uso no M�todo Main

No m�todo `Main`, demonstramos como usar o padr�o Factory:

1. Criamos inst�ncias de criadores concretos, como `ConcreteCreatorA` e `ConcreteCreatorB`.
2. Usamos esses criadores para criar inst�ncias de produtos concretos, como `ConcreteProductA` e `ConcreteProductB`, por meio do m�todo `CreateProduct()`.
3. Chamamos o m�todo `DoStuff()` nos produtos criados, para executar suas a��es espec�ficas.

Este exemplo ilustra como o padr�o Factory pode abstrair a cria��o de objetos, promovendo flexibilidade e organiza��o no c�digo.

## Execu��o

Para executar o exemplo, compile e execute o c�digo em um ambiente de desenvolvimento C#.

