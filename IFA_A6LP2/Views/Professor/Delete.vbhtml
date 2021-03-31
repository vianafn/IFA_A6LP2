@ModelType IFA_A6LP2.Professor
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Excluir</h2>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Excluir" class="btn btn-default" /> |
            @Html.ActionLink("Voltar", "Index")
        </div>
    End Using
</div>
