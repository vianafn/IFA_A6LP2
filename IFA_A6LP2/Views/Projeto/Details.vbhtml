@ModelType IFA_A6LP2.Projeto
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalhes</h2>

<div>
    <h4>Projeto</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tipo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tipo)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Código}) |
    @Html.ActionLink("Voltar", "Index")
</p>
