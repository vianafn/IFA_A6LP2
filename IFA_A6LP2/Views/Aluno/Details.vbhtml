@ModelType IFA_A6LP2.Aluno
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalhes</h2>

<div>
    <h4>Aluno</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Recebe_bolsa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Recebe_bolsa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Professor1.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Professor1.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Projeto1.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Projeto1.Nome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Matricula}) |
    @Html.ActionLink("Voltar", "Index")
</p>
