var rowMaterialPrice = [];
var rowEdgePrice = [];

function insertPrice(row)
{
    document.getElementById("OrderedMaterials_" + row + "__MaterialPrice").value = parseF(document.getElementById("OrderedMaterials_" + row + "__MaterialName").value);
}

function enableMaterialfields(row, value)
{
    let length = document.getElementById("OrderedMaterials_" + row + "__MaterialLength");
    let height = document.getElementById("OrderedMaterials_" + row + "__MaterialHeight");
    let quantity = document.getElementById("OrderedMaterials_" + row + "__MaterialQty");

    if (value != 0)
    {
        length.disabled = height.disabled = quantity.disabled = false;
    }
    else
    {
        let materialTotalPrice = document.getElementById("OrderedMaterials_" + row + "__MaterialTotalPrice");
        let quadrature = document.getElementById("OrderedMaterials_" + row + "__MaterialQuadrature");

        length.disabled = height.disabled = quantity.disabled = true;
        length.value = height.value = quantity.value = quadrature.value = materialTotalPrice.value = "0.00";
        enableEdgefields(row, false);
        calculateMaterialPrice(row);
    }
}

function calculateMaterialPrice(row)
{
    let length = document.getElementById("OrderedMaterials_" + row + "__MaterialLength");
    let height = document.getElementById("OrderedMaterials_" + row + "__MaterialHeight");
    let quantity = document.getElementById("OrderedMaterials_" + row + "__MaterialQty");
    let quadrature = document.getElementById("OrderedMaterials_" + row + "__MaterialQuadrature");
    let materialPrice = document.getElementById("OrderedMaterials_" + row + "__MaterialPrice");
    let materialTotalPrice = document.getElementById("OrderedMaterials_" + row + "__MaterialTotalPrice");

    length.value = parseF(length.value);
    height.value = parseF(height.value);
    quantity.value = parseF(quantity.value);

    if (length.value != 0 && height.value != 0 && quantity.value != 0)
    {
        quadrature.value = ((length.value * height.value) * quantity.value).toFixed(3);
        materialTotalPrice.value = (quadrature.value * parseF(materialPrice.options[materialPrice.selectedIndex].text)).toFixed(2);
        rowMaterialPrice[row] = materialTotalPrice.value;
        enableEdgefields(row, true);
    }
    else
    {
        materialTotalPrice.value = quadrature.value = "0.00";
        rowMaterialPrice[row] = 0;
        enableEdgefields(row, false);
    }

    calculateMaterialTotalPrice();
}

function enableEdgefields(row, enable)
{
    let h1 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeH1");
    let h2 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeH2");
    let l1 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeL1");
    let l2 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeL2");
    let totalPrice = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeTotalPrice");

    if (enable)
    {
        h1.disabled = h2.disabled = l1.disabled = l2.disabled = false;
    }
    else
    {
        h1.disabled = h2.disabled = l1.disabled = l2.disabled = true;
        h1.value = h2.value = l1.value = l2.value = rowEdgePrice[row] = 0;
        totalPrice.value = ("0.00");
        calculateEdgeTotalPrice();
    }
}

function calculateEdgePrice(row)
{
    let h1 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeH1");
    let h2 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeH2");
    let l1 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeL1");
    let l2 = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeL2");
    let quantity = document.getElementById("OrderedMaterials_" + row + "__MaterialQty");
    let totalPrice = document.getElementById("OrderedMaterials_" + row + "__MaterialEdgeTotalPrice");

    rowEdgePrice[row] = totalPrice.value = ((parseF(h1.value) + parseF(h2.value) + parseF(l1.value) + parseF(l2.value)) * parseF(quantity.value)).toFixed(2);

    calculateEdgeTotalPrice();
}

function calculateMaterialTotalPrice()
{
    let sum = 0;

    for (let i = 0; i < 12; i++)
    {
        if (!isNaN(rowMaterialPrice[i]))
        {
            sum += Number(rowMaterialPrice[i]);
        }
    }

    document.getElementById("MaterialPrice").value = sum.toFixed(2);

    calculateTotalPrice();
}

function calculateEdgeTotalPrice()
{
    let sum = 0;

    for (let i = 0; i < 12; i++)
    {
        if (!isNaN(rowEdgePrice[i]))
        {
            sum += Number(rowEdgePrice[i]);
        }
    }

    document.getElementById("EdgePrice").value = sum.toFixed(2);

    calculateTotalPrice();
}

function calculateTotalPrice()
{
    let sum = 0;

    for (let i = 0; i < 12; i++)
    {
        if (!isNaN(rowMaterialPrice[i]))
        {
            sum += Number(rowMaterialPrice[i]);
        }

        if (!isNaN(rowEdgePrice[i]))
        {
            sum += Number(rowEdgePrice[i]);
        }
    }

    if (document.getElementById("IsExpress").checked)
    {
        sum *= 1.25;
    }

    displayExpressWarning();

    document.getElementById("TotalPrice").value = sum.toFixed(2);
}

function parseF(value)
{
    value = parseFloat(value.replace(',', '.').replace(' ', ''));

    return (isNaN(value) || value < 0) ? 0 : value;
}

function displayExpressWarning()
{
    document.getElementById("expressAlert").style.display = document.getElementById("IsExpress").checked ? "inline" : "none";
}