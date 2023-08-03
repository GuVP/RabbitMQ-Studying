# RabbitMQ-Studying

RabbitMQ Docs: https://www.rabbitmq.com/documentation.html

## .NET Microservices Architecture:

![.NET Microservices](/NetCoreMicroservices.png)



## RabbitMQ Server UI:

- Abrir o Rabbit MQ Command Prompt.

- Executar o comando: rabbitmq-plugins enable rabbitmq_management

- Após isso, executar o Serviço do Rabbit MQ e abrir o navegador no endereço local: **localhost:15672**



## RabbitMQ Basic Commands

#### RabbitMQ Control (rabbitmqctl)

- rabbitmqctl stop_app: para o serviço.

* rabbitmqctl start_app: inicia o serviço.

* rabbitmqctl reset: limpa todos os dados do serviço. É necessário que o serviço não esteja em uso.

* rabbitmqctl add_user <username> <password>

* rabbitmqctl set_user_tags <username> <tag>

* rabbitmqctl set_permissions -p / <username> ".\*" ".\*" ".\*"

  * Primeiro".\*": Configura a permissão para todas entidades.

  * Segundo ".\*": Permissão de escrita para todas entidades.

  * Terceiro".\*": Permissão de leitura para todas entidades.

    *Entidades são: Filas, Exchanges e Bindings. 



## RabbitMQ no Visual Studio

#### Producer

É o projeto em que podemos enviar mensagens para uma fila chamada "BasicTest". Esse envio é feito através de um producer, o qual foi criado através da biblioteca disponibilizada pelo pacote RabbitMQ.Client (v6.5.0), instalada em nosso projeto.

#### Consumer

Aqui é onde podemos visualizar as mensagens postadas na fila "BasicTest". Isso ocorre pois criamos um consumer responsável por monitorar as mensagens postadas nesta fila e consumimos ela através do eventos receiver. Neste evento está a funcionalidade de escrever no console a mensagem consumida.