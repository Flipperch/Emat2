using System.IO;

namespace Emat2.WebApp.Client.Models
{
    public class UsuarioModel
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? RG { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
        public bool IsActive { get; set; }
    }
}


//CREATE TABLE [dbo].[USUARIO] (
//    [CODIGO]       SMALLINT      IDENTITY (1, 1) NOT NULL,
//    [NOME]         VARCHAR (100) NULL,
//    [NOME_ACESSO]  VARCHAR (20)  NULL,
//    [SENHA]        VARCHAR (20)  NULL,
//    [RG]           VARCHAR (20)  NULL,
//    [NIVEL_ACESSO] TINYINT       NULL,
//    [ATIVO]        BIT           NOT NULL,
//    PRIMARY KEY CLUSTERED ([CODIGO] ASC)
//);

//ADMINISTRADOR = 1,
//SECRETARIO = 2,
//SECRETARIOADM = 3,
//PROFESSOR = 4,
//COORDENADOR = 5,
//DIRETOR = 6