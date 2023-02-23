﻿using ArchitectureConceptsPOC.D;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Dtos;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.ChainOfResponsability.Handlers;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.Mediator;
using ArchitectureConceptsPOC.DesignPatterns.Behavioral.TemplateMethod;
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
        }
    }
}