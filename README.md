# https-github.com-DoeTeamOne-NetCore-MediatRDemo
Web Api Implementation of MidiatoR

MediatR is a popular open-source library for implementing the Mediator pattern in .NET applications. Here are the basic steps to configure MediatR in your .NET application:

1. Install the MediatR package via NuGet: You can install the MediatR package via the NuGet Package Manager or by using the Package Manager Console in Visual Studio. Use the following command to install the package:
Install-Package MediatR

2.Define your requests and handlers: MediatR uses a request/response pattern, where requests are objects that define the data needed to perform an action, and handlers are objects that perform the action in response to a request.

3. Register your services with your IoC container: You will need to register your requests and handlers with your IoC container. You can do this using the AddMediatR method in your ConfigureServices method. Here's an example:
services.AddMediatR(typeof(Startup));
NETCore 6
services.AddMediatR(typeof(Program));
4.Use MediatR in your controllers or services: Once MediatR is set up, you can use it in your controllers or services to handle requests. You can do this by injecting the IMediator interface into your constructor, like this:

private readonly IMediator _mediator;

public MyController(IMediator mediator)
{
    _mediator = mediator;
}


5.Send requests to MediatR: To send a request to MediatR, you can use the Send method on the IMediator interface, like this:
var response = await _mediator.Send(new MyRequest());


That's it! With these steps, you should have MediatR up and running in your .NET application. Of course, there are many more advanced features and configurations available in MediatR, but these steps should be enough to get you started.
