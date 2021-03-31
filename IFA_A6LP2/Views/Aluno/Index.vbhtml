@ModelType IEnumerable(Of IFA_A6LP2.Aluno)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Cadastrar", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Recebe_bolsa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Professor1.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Projeto1.Nome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Recebe_bolsa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Professor1.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Projeto1.Nome)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.Matricula}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.Matricula}) |
            @Html.ActionLink("Excluir", "Delete", New With {.id = item.Matricula})
        </td>
    </tr>
Next

</table>
