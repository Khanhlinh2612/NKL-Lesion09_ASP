@ModelType Nkl_Baithigiuaki.nklSinhVien
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.NklMaSV }) |
    @Html.ActionLink("Back to List", "Index")
</p>
