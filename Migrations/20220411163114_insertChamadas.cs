using Microsoft.EntityFrameworkCore.Migrations;

namespace controle_escolar.Migrations
{
    public partial class insertChamadas : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            
            mb.Sql("INSERT INTO Chamada(AlunoID, IdTurma, DataChamada, StatusChamada) VALUES(4, 2,'1998-07-15 00:00', true)");
            mb.Sql("INSERT INTO Chamada(AlunoID, IdTurma, DataChamada, StatusChamada) VALUES(6, 2,'2004-07-15 00:00', false)");
            mb.Sql("INSERT INTO Chamada(AlunoID, IdTurma, DataChamada, StatusChamada) VALUES(4, 2,'2008-07-15 00:00', true)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
