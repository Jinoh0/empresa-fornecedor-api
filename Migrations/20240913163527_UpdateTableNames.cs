using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaFornecedorAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FornecedorEmpresas_Empresas_EmpresaId",
                table: "FornecedorEmpresas");

            migrationBuilder.DropForeignKey(
                name: "FK_FornecedorEmpresas_Fornecedores_FornecedorId",
                table: "FornecedorEmpresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FornecedorEmpresas",
                table: "FornecedorEmpresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.RenameTable(
                name: "Fornecedores",
                newName: "fornecedores");

            migrationBuilder.RenameTable(
                name: "FornecedorEmpresas",
                newName: "fornecedorempresas");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "empresas");

            migrationBuilder.RenameColumn(
                name: "CNPJ_CPF",
                table: "fornecedores",
                newName: "CpfCnpj");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "fornecedores",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_FornecedorEmpresas_FornecedorId",
                table: "fornecedorempresas",
                newName: "IX_fornecedorempresas_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fornecedores",
                table: "fornecedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fornecedorempresas",
                table: "fornecedorempresas",
                columns: new[] { "EmpresaId", "FornecedorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_empresas",
                table: "empresas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_fornecedorempresas_empresas_EmpresaId",
                table: "fornecedorempresas",
                column: "EmpresaId",
                principalTable: "empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_fornecedorempresas_fornecedores_FornecedorId",
                table: "fornecedorempresas",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fornecedorempresas_empresas_EmpresaId",
                table: "fornecedorempresas");

            migrationBuilder.DropForeignKey(
                name: "FK_fornecedorempresas_fornecedores_FornecedorId",
                table: "fornecedorempresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fornecedores",
                table: "fornecedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fornecedorempresas",
                table: "fornecedorempresas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empresas",
                table: "empresas");

            migrationBuilder.RenameTable(
                name: "fornecedores",
                newName: "Fornecedores");

            migrationBuilder.RenameTable(
                name: "fornecedorempresas",
                newName: "FornecedorEmpresas");

            migrationBuilder.RenameTable(
                name: "empresas",
                newName: "Empresas");

            migrationBuilder.RenameColumn(
                name: "CpfCnpj",
                table: "Fornecedores",
                newName: "CNPJ_CPF");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fornecedores",
                newName: "FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_fornecedorempresas_FornecedorId",
                table: "FornecedorEmpresas",
                newName: "IX_FornecedorEmpresas_FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedores",
                table: "Fornecedores",
                column: "FornecedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FornecedorEmpresas",
                table: "FornecedorEmpresas",
                columns: new[] { "EmpresaId", "FornecedorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_FornecedorEmpresas_Empresas_EmpresaId",
                table: "FornecedorEmpresas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FornecedorEmpresas_Fornecedores_FornecedorId",
                table: "FornecedorEmpresas",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "FornecedorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
