using ArchitectureConceptsPOC.D;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Handlers;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Command;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Iterator;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Mediator;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Memento;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Observer;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.State;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Strategy;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Visitor;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter.CodigoExistente;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Composite;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Decorator;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Facade;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Flyweight;
using ArchitectureConceptsPOC.DesignPatterns.Structural.Proxy;
using ArchitectureConceptsPOC.I;
using ArchitectureConceptsPOC.L;
using ArchitectureConceptsPOC.O;
using ArchitectureConceptsPOC.S;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Base.Interfaces;
using ArchitectureConceptsPOC.SOLID.AbstractFactory.Model;
using ArchitectureConceptsPOC.SOLID.Prototype;
using ArchitectureConceptsPOC.SOLID.Prototype.Interfaces;
using ArchitectureConceptsPOC.SOLID.Singleton;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ArchitectureConceptsPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlgumaClasse ac = new AlgumaClasse();

            //S
            //AlgumaClasse classe = new AlgumaClasse(/*dependencias*/);
            //classe.AlgumServico(/*parametros*/);

            //O
            //O.AlgumaClasseFilha filha = new O.AlgumaClasseFilha();
            //filha.AlgumServicoClasseFilha();

            //L
            //AlgumaClasseQuePrecisaDeOutraClasse classeDepende = new AlgumaClasseQuePrecisaDeOutraClasse();
            //classeDepende.ServicoQuePrecisaDeOutraClasse(new FilhaUm()
            //                                            /* new FilhaDois()*/);

            //I
            //I.Demo demo = new I.Demo();

            //D
            //ServiceCollection collection = new ServiceCollection();
            //collection.AddScoped<IServicosClasseBase, D.AlgumaClasseBase>();
            //var serviceProvider = collection.BuildServiceProvider();
            //var service = serviceProvider.GetService<IServicosClasseBase>();

            //AbstractFactory
            /*
            IAbstractFactory myFactory = new ConcreteFactory(
                                                new BaseFactory(),
                                                new FakeFactory());

            Person fakeTeacher = myFactory.CreateFakeTeacher();
            Person fakeLawyer = myFactory.CreateFakeLawyer();
            Person realTeacher = myFactory.CreateRealTeacher();
            Person realLawyer = myFactory.CreateRealLawyer();

            Console.WriteLine($"Fake Teacher: {fakeTeacher}");
            Console.WriteLine($"Fake Lawyer: {fakeLawyer}");
            Console.WriteLine($"Real Teacher: {realTeacher}");
            Console.WriteLine($"Real Lawyer: {realLawyer}");
            */

            //Prototype
            /*
            var objeto = new ClassePrototipavel();
            objeto.Nome = "Objeto :D";
            objeto.Documento = "ABCD1234";

            var outraInstancia = objeto.Clone();
            Console.WriteLine($"Objeto: " + objeto);
            Console.WriteLine($"Clone: " + outraInstancia);
            Console.WriteLine(objeto == outraInstancia);
            */

            /*
            //Singleton
            var instancia = Singleton.Instancia;
            var maisUmaInstancia = Singleton.Instancia;

            Console.WriteLine(instancia == maisUmaInstancia);
            */

            //Adapter
            /*
            IAdapter adapter = new Adapter(new Servico());

            var request = new AlgumRequestDto()
            {
                Id = Guid.NewGuid(),
                Nome = "Algum Request Meu"
            };

            adapter.Executar(request);
            */

            //Bridge
            // O Conceito de mensagem neste exemplo tem dois aspectos:
            // - Tamanho da mensagem
            // - Forma de envio;

            /*
            Message message = new Message()
            {
                Title = "Titulo da Minha Mensagem",
                Content = "Mensagem muito longa"
            };

            AbstractMessageHandler longMessageHandler = new LongMessageHandler(new EmailMessageSender());
            longMessageHandler.SendMessage(message);

            AbstractMessageHandler shortMessageHandler = new ShortMessageHandler(new SMSMessageSender());
            shortMessageHandler.SendMessage(message);

            message.Content = "Message";
            shortMessageHandler.SendMessage(message);
            */

            //Composite
            /*
            CompoundGraphic figuraComposta = new CompoundGraphic();
            figuraComposta.Add(new Dot(3, 3));
            figuraComposta.Add(new Dot(6, 3));
            figuraComposta.Add(new Circle(0, 0, 10));

            figuraComposta.Draw();
            figuraComposta.Move(10, 10);

            figuraComposta.Draw();
            */

            //Decorator
            /*
            ConcreteComponent componenteConcreto = new ConcreteComponent();
            componenteConcreto.Execute();

            ConcreteDecorator decoratorConcreto = new ConcreteDecorator(componenteConcreto);
            decoratorConcreto.Execute();
            */

            //Façade
            /*
            var request = new DesignPatterns.Structural.Facade.AlgumRequestDto()
            {
                AlgumModel = new AlgumModel(),
                AlgumOutroModel = new AlgumOutroModel()
            };

            AlgumService service = new AlgumService(new AlgumRepository(), new AlgumOutroRepository());
            service.TratarRequest(request);
            */

            //FlyWeight
            /*
            Floresta floresta = new Floresta();

            //Parte Imutável
            ArvoreTipo carvalho = new ArvoreTipo("Carvalho", "marrom", "oak.png");
            ArvoreTipo macieira = new ArvoreTipo("Macieira", "marrom-claro", "appleTree.png");

            floresta.PlantarArvore(30, 30, carvalho);
            floresta.PlantarArvore(30, 40, carvalho);

            floresta.PlantarArvore(50, 30, macieira);
            floresta.PlantarArvore(50, 40, macieira);

            floresta.Draw("Tela");
            */

            //Proxy
            /*
            Proxy proxy = new Proxy(new Service());
            proxy.Operation();
            */

            //Chain of Responsability
            /*
            ValidationHandlerRequestDto request = new ValidationHandlerRequestDto()
            {
                Name = "Some invalid name",
                Email = "ahdskahdkas@hotmail.com"
            };
            
            ValidationRequestHandler handler = new ValidationRequestHandler();
            handler.Handle(request);

            request.Name = "Adrian";
            request.Email = "abc@johnson.br";

            handler.Handle(request);

            request.Email = "something@hotmail.com";

            handler.Handle(request);
            */

            //Mediator
            /*
            ServiceCollection collection = new ServiceCollection();
            collection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
            collection.AddTransient<IRequestHandler<SomeMediatorRequestDto, SomeMediatorResponseDto>, SomeHandler>();
            collection.AddTransient<ISomeClassThatNeedsMediator, SomeClassThatNeedsMediator>();
            var serviceProvider = collection.BuildServiceProvider();
            
            ISomeClassThatNeedsMediator someClassThatNeedsMediator = serviceProvider.GetService<ISomeClassThatNeedsMediator>();
            someClassThatNeedsMediator.Execute();
            */

            //Template Method
            /*
            Context context = new Context();
            ProfessorRepository professores = new ProfessorRepository(context);

            var profsD = professores.GetProfessoresWithDisciplinasAsync().Result;
            */

            //Command
            /*
            TargetActionsModel doc = new TargetActionsModel("Doc File");
            TargetActionsModel zip = new TargetActionsModel("Zip File");
            ICommand oneCommand = new TargetActionOneCommand(doc);
            ICommand anotherOneCommand = new TargetActionOneCommand(zip);

            ICommand twoCommand = new TargetActionTwoCommand(doc);
            ICommand threeCommand = new TargetActionThreeCommand(doc);

            TargetActionsInvoker someInvoker = new TargetActionsInvoker(oneCommand, twoCommand, threeCommand);
            TargetActionsInvoker someOtherInvoker = new TargetActionsInvoker(anotherOneCommand, twoCommand, threeCommand);

            someInvoker.clickOne();
            someOtherInvoker.clickOne();

            someInvoker.clickTwo();
            someOtherInvoker.clickTwo();
            */

            //Iterator
            /*
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            Iterator iterator = collection.CreateIterator();
            
            iterator.Step = 1;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            iterator.Step = 2;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
            */

            //Memento
            /*
            ClientCodeThatHandlesAndUseMemento client = new ClientCodeThatHandlesAndUseMemento();
            client.DoSomething();
            */

            //Observer
            /*
            var mostrador = new MostradorDeMensagem();
            var salvador = new SalvadorDeMensagem();
            var publisher = new Publisher();

            publisher.Subscribe(mostrador);
            publisher.Subscribe(salvador);

            publisher.NotifyAllSubscribers(new DesignPatterns.Behavioral.Observer.Message()
            {
                Nome = "Eu sou a mensagem",
                Idade = 2
            }); 
            */

            //State
            /*
            DesignPatterns.Behavioral.State.Context context = 
                new DesignPatterns.Behavioral.State.Context(new SomeState());

            context.Execute();
            context.StateChangeTo(new SomeOtherState());

            context.Execute();
            context.StateChangeTo(new StateThatRunsAndChangeItself(context));

            context.Execute();
            context.Execute();
            */

            //Visitor
            /*
            IList<IShape> allShapes = new List<IShape>();
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Circle());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Dot());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Dot());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Circle());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.CompoundGraphic());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.CompoundGraphic());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Dot());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Dot());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.Circle());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.CompoundGraphic());
            allShapes.Add(new DesignPatterns.Behavioral.Visitor.CompoundGraphic());

            var exportVisitor = new XMLExportVisitor();
            foreach (var shape  in allShapes)
            {
                shape.Accept(exportVisitor);
            }
            */

            //Strategy
            /*
            DataDto data = new DataDto();
            DesignPatterns.Behavioral.Strategy.Context context = new DesignPatterns.Behavioral.Strategy.Context();
            Console.Write("Entre um numero: ");
            data.a = int.Parse(Console.ReadLine());

            Console.Write("Entre outro numero: ");
            data.b = int.Parse(Console.ReadLine());

            context.SetStrategy(new Sum());
            context.RunStrategy(data);

            context.SetStrategy(new Diff());
            context.RunStrategy(data);

            context.SetStrategy(new Multiply());
            context.RunStrategy(data);
            */
        }
    }
}
