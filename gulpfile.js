const gulp = require("gulp");
const postcss = require("gulp-postcss");
const cleanCSS = require("gulp-clean-css");

gulp.task("css:dev", () => {
  return gulp
    .src("./Styles/site.css")
    .pipe(
      postcss([
        require("precss"),
        require("tailwindcss"),
        require("autoprefixer"),
      ])
    )
    .pipe(gulp.dest("./wwwroot/css/"));
});

gulp.task("css:prod", () => {
  return gulp
    .src("./Styles/site.css")
    .pipe(
      postcss([
        require("precss"),
        require("tailwindcss"),
        require("autoprefixer"),
      ])
    )
    .pipe(cleanCSS({ level: 2 }))
    .pipe(gulp.dest("./wwwroot/css/"));
});
