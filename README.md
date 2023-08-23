# Padrão Factory em C#

O padrão Factory é um padrão de projeto de criação que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses escolham os tipos de objetos a serem criados. Isso abstrai o processo de criação de objetos e facilita a manutenção e extensibilidade do código.

## Implementação

Neste exemplo em C#, demonstramos a implementação do padrão Factory com um cenário de criação de produtos e criadores concretos.

### Classes de Produtos

- `ConcreteProductA` e `ConcreteProductB` são classes concretas que implementam a interface `IProduct`. Elas representam diferentes tipos de produtos que podem ser criados.

### Classes de Criadores

- `Creator` é a classe abstrata base para os criadores concretos. Ela define o método abstrato `CreateProduct()`, que será implementado pelas subclasses.

- `ConcreteCreatorA` e `ConcreteCreatorB` são as subclasses de criadores concretos. Elas estendem `Creator` e implementam o método `CreateProduct()` para criar instâncias dos produtos correspondentes.

### Uso no Método Main

No método `Main`, demonstramos como usar o padrão Factory:

1. Criamos instâncias de criadores concretos, como `ConcreteCreatorA` e `ConcreteCreatorB`.
2. Usamos esses criadores para criar instâncias de produtos concretos, como `ConcreteProductA` e `ConcreteProductB`, por meio do método `CreateProduct()`.
3. Chamamos o método `DoStuff()` nos produtos criados, para executar suas ações específicas.

Este exemplo ilustra como o padrão Factory pode abstrair a criação de objetos, promovendo flexibilidade e organização no código.

## Execução

Para executar o exemplo, compile e execute o código em um ambiente de desenvolvimento C#.

