using FactoryMethodProject;

Creator creatorA = new ConcreteCreatorA();
IProduct productA = creatorA.CreateProduct();
productA.DoStuff();

Creator creatorb = new ConcreteCreatorB();
IProduct productB = creatorb.CreateProduct();
productB.DoStuff();
