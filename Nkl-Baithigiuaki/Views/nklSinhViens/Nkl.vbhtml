@ModelType Nkl_Baithigiuaki.nklSinhVien
@Code
    ViewData("Title") = "NklDelete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>nklSinhVien</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NklHoSV)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NklHoSV)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NklNgaySinh)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NklNgaySinh)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NklPhai)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NklPhai)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NklPhone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NklPhone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NkllEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NkllEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nklKhoa.NklTenKH)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nklKhoa.NklTenKH)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "NklsIndex")
        </div>
    End Using
</div>
