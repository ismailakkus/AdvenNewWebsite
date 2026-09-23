/************************************/
//default editor
/************************************/
$(".summernote").summernote({
    height: 225, // set editor height
    minHeight: null, // set minimum height of editor
    maxHeight: null, // set maximum height of editor
    focus: false, // set focus to editable area after initializing summernote
});

$(".summernote1").summernote({
    height: 600, // set editor height
    minHeight: null, // set minimum height of editor
    maxHeight: null, // set maximum height of editor
    focus: false, // set focus to editable area after initializing summernote
});

$(".summernote2").summernote({
    height: 375, // set editor height
    minHeight: null, // set minimum height of editor
    maxHeight: null, // set maximum height of editor
    focus: false, // set focus to editable area after initializing summernote
});

/************************************/
//inline-editor
/************************************/
$(".inline-editor").summernote({
    airMode: true,
});

/************************************/
//edit and save mode
/************************************/
(window.edit = function () {
    $(".click2edit").summernote();
}),
    (window.save = function () {
        $(".click2edit").summernote("destroy");
    });

var edit = function () {
    $(".click2edit").summernote({ focus: true });
};

var save = function () {
    var markup = $(".click2edit").summernote("code");
    $(".click2edit").summernote("destroy");
};

/************************************/
//airmode editor
/************************************/
$(".airmode-summer").summernote({
    airMode: true,
});