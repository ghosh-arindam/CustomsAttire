import React, { useState, useEffect, useRef, useCallback } from "react";
import { Box, Button, TextField, Grid, Stack } from "@mui/material";
// import { tokens } from "../../theme";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import AddIcon from "@mui/icons-material/Add";
import Save from "@mui/icons-material/Save";
import Cancel from "@mui/icons-material/Cancel";
import { useDispatch, useSelector } from "react-redux";
import { loadProduct } from "./../../redux/action";
import { useNavigate } from "react-router-dom";
//import { Formik } from "formik";
import ProductDropDownComponent from "./../../components/ProductDropDown";
import { Autocomplete } from "@mui/material";
import { addPurchaseOrders } from "./../../redux/action";
const PurchaseOrders = () => {
  //const theme = useTheme();
  //const colors = tokens(theme.palette.mode);
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const navigate = useNavigate();
  const [selectedVendor, setSelectedVendor] = useState("");
  const [total, setTotal] = useState(0);
  const [grandTotal, setGrandTotal] = useState(0);
  // eslint-disable-next-line
  const [quantityPurchased, setQuantityPurchased] = useState("");
  // eslint-disable-next-line
  const [fabricDescription, setfabricDescription] = useState();
  // eslint-disable-next-line
  const [fabricCode, setfabricCode] = useState();
  // eslint-disable-next-line
  const [due, setDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState();
  // eslint-disable-next-line
  const [searchValue, setSearchValue] = useState("");
  // eslint-disable-next-line
  const [selectedFabric, setSelectedFabric] = useState(null);
  const [inputDue, setInputDue] = useState(0);
  const dispatch = useDispatch();
  const [rows, setRows] = useState([]);
  const [selectedFabrics, setSelectedFabrics] = useState(); // state variable to store selected fabrics
  // eslint-disable-next-line
  const [fabrics, setFabrics] = useState([]);
  // eslint-disable-next-line
  const [qty, setqty] = useState();
  const [selectedDescription, setSelectedDescription] = useState();
  const { Products } = useSelector((state) => state.data);
  const tableRef = useRef(null);
  useEffect(() => {
    //dispatch(loadSuppliers());
    dispatch(loadProduct());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const handleAdvChange = (e) => {
    const due = grandTotal - e.target.value;
    setInputAdvance(e.target.value);
    setInputDue(due);
  };

  useEffect(() => {
    if (selectedFabrics?.length) {
      // const fabricCode = selectedFabrics[selectedFabrics.length - 1].code;
      setfabricCode(selectedFabrics);
    }
  }, [selectedFabrics]);

  // console.log(Products);
  const calculateTotal = (rowId) => {
    const qty = document.getElementById(`qty${rowId}`).value;

    const price = parseFloat(document.getElementById(`price${rowId}`).value);
    const total = qty * price;
    document.getElementById(`total${rowId}`).innerText = total.toFixed(2);
    setQuantityPurchased((prevSelectedQty) => [
      ...prevSelectedQty,
      {
        quantityPurchased: document.getElementById(`qty${rowId}`).value,
      },
    ]);

    let newGrandTotal = 0;
    rows.forEach((row) => {
      const qty = parseFloat(document.getElementById(`qty${row.id}`).value);
      const price = parseFloat(document.getElementById(`price${row.id}`).value);
      const total = qty * price;
      newGrandTotal += total;
    });
    setGrandTotal(newGrandTotal.toFixed(2));

    const newDue = newGrandTotal - parseFloat(inputAdvance);
    setDue(newDue.toFixed(2));
    setInputDue(newDue.toFixed(2));
  };

  const handleSelectFabricChange = useCallback(
    (newValue, value) => {
      const { fabricCode, description } = newValue;

      console.log("newValue" + JSON.stringify(newValue));
      console.log("value" + value);

      if (newValue !== undefined) {
        // console.log("fabric Code")
        // let newSplit = newValue.split(",");
        // console.log("new Split", newSplit)
        // let fabricCode = newSplit[1].split(":");
        // console.log(fabricCode)
        // let fabricDescription = newSplit[2].split(":");
        // setfabricDescription(value.description);
        let fabricCode = newValue.fabricCode;
        let Description = newValue.description;
        console.log(fabricCode);
        console.log(Description);
        // console.log('fabricCode'+fabricCode)
        setSelectedFabrics(fabricCode);
        setSelectedDescription(Description);

        // setfabricDescription(
        //   JSON.stringify({ code: fabricCode[1], description: fabricDescription[1] })
        // );
        // setSelectedFabrics((prevSelectedFabrics) => [      ...prevSelectedFabrics,      {        code: fabricCode[1],
        //     // description: fabricDescription[1],
        //   },
        // ]);
        console.log("handleSelectFabricChange" + selectedFabrics);
      }
    },
    //eslint-disable-next-line react-hooks/exhaustive-deps
    []
  );

  const handleSubmit = (values) => {
    //dispatch(addPurchaseOrders(values));
    console.log(values);
    navigate("/dashboard");
  };

  const saveData = () => {
    const data = rows.map((row) => ({
      vendorName: selectedVendor.name,
      fabricCode: selectedFabrics,
      description: selectedDescription,
      quantityPurchased: parseFloat(
        document.getElementById(`qty${row.id}`).value
      ),
      costPrice: parseFloat(document.getElementById(`price${row.id}`).value),
      totalCostPrice: grandTotal,
      paymentmode: "",
      paymentdone: inputAdvance,
      duepayment: inputDue,
      purchasedate: new Date().toISOString().slice(0, 10),
    }));
    localStorage.setItem("purchaseOrdersData", JSON.stringify(data));
    dispatch(addPurchaseOrders(data));
    // console.log(fabricCode)
    console.log(data);
  };

  const addRow = () => {
    //console.log(rows);
    const newRow = {
      id: rows.length + 1,
      fabricCode: "",
      desc: "",
      qty: "",
      price: "",
      total: "0",
    };
    setRows([...rows, newRow]);
  };
  const vendors = Products?.map((product) => product.vendorName) || [];

  const filteredVendors = vendors
    ?.filter((vendor, index) => vendors.indexOf(vendor) === index)
    .map((vendor) => ({ name: vendor }));

  function PurchaseOrders(props) {
    console.log("props:", props);
    const filteredOrders = props.orders.filter(
      (order) => order.status === "pending"
    );
    console.log("filteredOrders:", filteredOrders);
  }

  return (
    <Grid sx={{ flexGrow: 1 }} mx={4}>
      <Header title="PURCHASE ORDERS" subtitle="List of Purchase Orders Made" />
      <form onSubmit={handleSubmit} autoComplete="off">
        <Box
          display="grid"
          gap="30px"
          gridTemplateColumns="repeat(3, minmax(0, 1fr))"
          sx={{
            "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
          }}
        >
          <Box sx={{ width: 1 / 2 }}>
            <Button
              variant="contained"
              color="primary"
              startIcon={<AddIcon />}
              size="medium"
              onClick={addRow}
            >
              Add Purchase Orders
            </Button>
          </Box>
          <Box sx={{ width: 1 / 4 }}></Box>
          <Box sx={{ mx: "auto", p: 1, mt: 1 }}>
            <Autocomplete
              id="vendor"
              options={filteredVendors}
              getOptionLabel={(option) => option.name || ""}
              value={selectedVendor}
              sx={{ gridColumn: "span 4" }}
              style={{ width: 300 }}
              onChange={(event, value) => setSelectedVendor(value)}
              renderInput={(params) => (
                <TextField
                  {...params}
                  label="Search Vendor"
                  variant="outlined"
                  size="medium"
                />
              )}
            />
          </Box>
        </Box>
        <Box my={4}>
          <TableContainer component={Paper}>
            <Table
              sx={{ minWidth: 700 }}
              aria-label="spanning table"
              ref={tableRef}
            >
              <TableHead>
                <TableRow>
                  <TableCell align="left" colSpan={3}>
                    Fabric Code
                  </TableCell>
                  <TableCell align="center">Details</TableCell>

                  <TableCell align="right">Price</TableCell>
                </TableRow>
                <TableRow>
                  <TableCell align="left">Fabric Code</TableCell>
                  <TableCell align="center"></TableCell>
                  <TableCell align="center">Qty.</TableCell>
                  <TableCell align="center">Unit</TableCell>
                  <TableCell align="right">Sum</TableCell>
                </TableRow>
              </TableHead>
              <TableBody>
                {rows?.map((row, index) => (
                  <TableRow key={row.id}>
                    <TableCell>
                      <ProductDropDownComponent
                        value={fabricDescription}
                        onChange={handleSelectFabricChange}
                      />
                    </TableCell>
                    <TableCell></TableCell>
                    <TableCell align="center">
                      <TextField
                        align="left"
                        label="Quantity"
                        id={`qty${row.id}`}
                        name="quantityPurchased"
                        onChange={(event) => calculateTotal(row.id)}
                      />
                    </TableCell>
                    <TableCell align="center">
                      <TextField
                        label="Unit Price"
                        id={`price${row.id}`}
                        name="costPrice"
                        onChange={() => calculateTotal(row.id)}
                      />
                    </TableCell>
                    <TableCell
                      align="right"
                      id={`total${row.id}`}
                      onChange={(e) => setTotal(e.target.value)}
                    >
                      {total}
                    </TableCell>
                  </TableRow>
                ))}
                <TableRow>
                  <TableCell rowSpan={4} />
                  <TableCell colSpan={3}>Grand Total</TableCell>
                  <TableCell align="right" name="totalCostPrice">
                    {grandTotal}
                  </TableCell>
                </TableRow>
                <TableRow>
                  <TableCell>Advance</TableCell>
                  <TableCell align="right" colSpan={3}>
                    <TextField
                      label="Advance"
                      value={inputAdvance}
                      name="paymentdone"
                      onChange={handleAdvChange}
                    />
                  </TableCell>
                </TableRow>
                <TableRow>
                  <TableCell colSpan={3}>Total Due</TableCell>
                  <TableCell align="right" name="duepayment">
                    {inputDue}
                  </TableCell>
                </TableRow>
              </TableBody>
            </Table>
          </TableContainer>
          <Box sx={{ width: 1 / 4 }} my={4}></Box>
          <Stack
            direction="row"
            spacing={2}
            sx={{ width: 1 / 2 }}
            mx={1}
            display="flex"
            justifyContent="end"
            mt="20px"
          >
            <Button variant="contained" startIcon={<Save />} onClick={saveData}>
              Save
            </Button>
            <Button variant="contained" endIcon={<Cancel />}>
              Cancel
            </Button>
          </Stack>
        </Box>
      </form>
    </Grid>
  );
};

export default PurchaseOrders;
