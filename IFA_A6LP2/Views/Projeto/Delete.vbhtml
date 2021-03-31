@ModelType IFA_A6LP2.Projeto
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Excluir</h2>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Excluir" class="btn btn-default" /> |
            @Html.ActionLink("Voltar", "Index")
        </div>
    End Using
</div>
