
CKEDITOR.editorConfig = function (config) {

    config.filebrowserBrowseUrl = '/js/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/js/ckfinder/ckfinder.html?type=Images';
    config.filebrowserFlashBrowseUrl = '/js/ckfinder/ckfinder.html?type=Flash';
    config.filebrowserUploadUrl = '/js/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '/js/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    config.filebrowserFlashUploadUrl = '/js/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
};
