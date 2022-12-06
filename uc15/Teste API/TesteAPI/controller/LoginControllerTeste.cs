using Chapter.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter.Models;
using Chapter.ViewModels;
using Chapter.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TesteAPI.controller
{
    public class LoginControllerTeste
    {
        public void LoginController_Retornar_Usuario_Invalido()
        {
            var fakeRepository = new Mock<IUsuarioRepository>();

            fakeRepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            LoginViewModel dadosLogin = new LoginViewModel();

            dadosLogin.Email = "email@email.com";
            dadosLogin.Senha = "123";

            var controller = new LoginController(fakeRepository.Object);

            // Act
            var resultado = controller.Login(dadosLogin);

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
        
    }
}
