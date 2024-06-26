@ModelType Nkl_Baithigiuaki.nklSinhVien
@Code
    ViewData("Title") = "NklCreate"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>nklSinhVien</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklMaSV, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NklMaSV, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NklMaSV, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklHoSV, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NklHoSV, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NklHoSV, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklNgaySinh, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NklNgaySinh, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NklNgaySinh, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklPhai, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                <div class="checkbox">
                    @Html.EditorFor(Function(model) model.NklPhai)
                    @Html.ValidationMessageFor(Function(model) model.NklPhai, "", New With { .class = "text-danger" })
                </div>
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklPhone, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NklPhone, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NklPhone, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NkllEmail, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NkllEmail, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NkllEmail, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NklMaKH, "NklMaKH", htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("NklMaKH", Nothing, htmlAttributes:= New With { .class = "form-control" })
                @Html.ValidationMessageFor(Function(model) model.NklMaKH, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "NklIndex")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
