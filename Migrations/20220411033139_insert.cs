using Microsoft.EntityFrameworkCore.Migrations;

namespace controle_escolar.Migrations
{
    public partial class insert : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0001','Pedro','1993-01-11')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0002','Maria','1989-03-21')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0003','Joao','1997-04-13')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0004','Rute','1998-07-15')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0005','Luisa','1996-11-14')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0006','Rosangela','1994-12-17')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0007','Gabriel','2001-09-07')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0008','Enzo','2003-01-09')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0009','Sara','1990-02-03')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0010','Lorena','1999-08-02')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0011','Mario','2003-01-09')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('0012','Robson','1990-02-03')");
            mb.Sql("INSERT INTO Alunos(Matricula,Nome,DataNascimento) VALUES('00013','Jessica','1999-08-02')");
            
            mb.Sql("INSERT INTO Turmas (Nome, Turno) VALUES ('Matematica', 1)");
            mb.Sql("INSERT INTO Turmas (Nome, Turno) VALUES ('Portugues', 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
