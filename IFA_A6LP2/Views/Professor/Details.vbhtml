@ModelType IFA_A6LP2.Professor
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalhes</h2>

<div>
    <h4>Professor</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Matricula}) |
    @Html.ActionLink("Voltar", "Index")
</p>
