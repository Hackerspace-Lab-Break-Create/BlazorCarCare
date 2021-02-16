module.exports = {
  purge: {
    enabled: true,
    preserveHtmlElements: false,
    content: ["./**/*.html", "./**/*.razor"],
    options: {
      keyframes: true,
    },
  },
  theme: {
    extend: {
      colors: {
        carcare: "#68a0b2",
      },
    },
  },
};
