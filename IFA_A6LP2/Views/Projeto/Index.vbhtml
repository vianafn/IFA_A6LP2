@ModelType IEnumerable(Of IFA_A6LP2.Projeto)
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
            @Html.DisplayNameFor(Function(model) model.Tipo)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tipo)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.Código}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.Código}) |
            @Html.ActionLink("Excluir", "Delete", New With {.id = item.Código})
        </td>
    </tr>
Next

</table>
