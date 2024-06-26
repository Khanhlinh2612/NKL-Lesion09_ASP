@ModelType IEnumerable(Of Nkl_Baithigiuaki.nklSinhVien)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "NklCreate")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.NklHoSV)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NklNgaySinh)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NklPhai)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NklPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NkllEmail)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nklKhoa.NklTenKH)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NklHoSV)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NklNgaySinh)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NklPhai)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NklPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NkllEmail)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nklKhoa.NklTenKH)
        </td>
        <td>
            @Html.ActionLink("NklEdit", "NklEdit", New With {.id = item.NklMaSV}) |
            @Html.ActionLink("NklDetails", "NklDetails", New With {.id = item.NklMaSV}) |
            @Html.ActionLink("NklDelete", "NklDelete", New With {.id = item.NklMaSV})
        </td>
    </tr>
Next

</table>
