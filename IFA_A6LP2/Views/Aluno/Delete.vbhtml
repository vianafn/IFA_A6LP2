@ModelType IFA_A6LP2.Aluno
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Excluir</h2>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Excluir" class="btn btn-default" /> |
            @Html.ActionLink("Voltar", "Index")
        </div>
    End Using
</div>
