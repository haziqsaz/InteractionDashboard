window.telerikClientExporter = {
    exportChart: function (chartId, format) {
        const chartElement = document.getElementById(chartId);
        if (!chartElement) {
            console.error(`Chart element with id '${chartId}' not found.`);
            return;
        }

        kendo.drawing.drawDOM(chartElement, {
            paperSize: "auto",
            margin: "1cm"
        }).then(function (group) {
            if (format === "png") {
                return kendo.drawing.exportImage(group);
            } else if (format === "pdf") {
                return kendo.drawing.exportPDF(group);
            } else if (format === "svg") {
                return kendo.drawing.exportSVG(group);
            } else {
                throw new Error("Unsupported format: " + format);
            }
        }).then(function (dataURI) {
            const link = document.createElement("a");
            link.download = `chart-export.${format}`;
            link.href = dataURI;
            document.body.appendChild(link);
            link.click();
            document.body.removeChild(link);
        });
    }
};
