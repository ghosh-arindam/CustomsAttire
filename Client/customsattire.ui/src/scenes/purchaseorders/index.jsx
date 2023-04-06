import React, { useState, useEffect, useRef, useCallback } from "react";
import { Box, Button, TextField, MenuItem, Grid, Stack } from "@mui/material";
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
const PurchaseOrders = () => {
  //const theme = useTheme();
  //const colors = tokens(theme.palette.mode);
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const navigate = useNavigate();
  const [selectedVendor, setSelectedVendor] = useState("");
  const [total, setTotal] = useState(0);
  const [grandTotal, setGrandTotal] = useState(0);
  const [quantityPurchased, setQuantityPurchased] = useState("");
  const [fabricDescription, setfabricDescription] = useState();
  // eslint-disable-next-line
  const [due, setDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState(0);
  // eslint-disable-next-line
  const [searchValue, setSearchValue] = useState("");
  // eslint-disable-next-line
  const [selectedFabric, setSelectedFabric] = useState(null);
  const [inputDue, setInputDue] = useState(0);
  const dispatch = useDispatch();
  const [rows, setRows] = useState([]);
  const [selectedFabrics, setSelectedFabrics] = useState([]); // state variable to store selected fabrics
  // eslint-disable-next-line
  const [fabrics, setFabrics] = useState([]);

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
    console.log(quantityPurchased);
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

  // const handleSelectFabricChange = useCallback((newValue) => {
  //   console.log("parentComponet" + newValue);
  //   setfabricDescription(newValue);
  //   let newSplit = newValue.split(',')
  //   console.log(newSplit)
  //   let fabricCode = newSplit[0].split(':')
  //   let fabricDescription = newSplit[1].split(':')
  //   setSelectedFabric(fabricCode[1])
  //   console.log(fabricDescription[1])
  //   setfabricDescription(fabricDescription[1])

  // }, []);

  // const handleSelectFabricChange = useCallback((newValue) => {
  //   console.log("parentComponet" + newValue);
  //   setfabricDescription(newValue);
  //   let newSplit = newValue.split(',');
  //   console.log(newSplit);
  //   let fabricCode = newSplit[0].split(':');
  //   let fabricDescription = newSplit[1].split(':');
  //   setSelectedFabrics(prevSelectedFabrics => [  ...prevSelectedFabrics.slice(),    {        code: fabricCode[1],
  //     description: fabricDescription[1]
  //   }
  // ]
  // );

  // }, []);
  const handleSelectFabricChange = useCallback((newValue) => {
    let newSplit = newValue.split(",");
    let fabricCode = newSplit[0].split(":");
    let fabricDescription = newSplit[1].split(":");
    setfabricDescription(
      JSON.stringify({ code: fabricCode[1], description: fabricDescription[1] })
    );
    setSelectedFabrics((prevSelectedFabrics) => [
      ...prevSelectedFabrics,
      {
        code: fabricCode[1],
        description: fabricDescription[1],
      },
    ]);
    console.log(selectedFabrics);
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const handleSubmit = (values) => {
    const data = {
      fabricDescription,
      selectedFabrics,
      quantityPurchased,
    };
    const jsonData = JSON.stringify(data);
    localStorage.setItem("purchaseOrder", jsonData);
    console.log(values);
    navigate("/dashboard");
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

  // const vendors = Products?.map((product) => product.vendorName) || []

  // const filteredVendors = vendors.filter((vendor, index) => vendors.indexOf(vendor) === index).map((vendor) => ({ name: vendor }));
  function PurchaseOrders(props) {
    console.log("props:", props);
    const filteredOrders = props.orders.filter(
      (order) => order.status === "pending"
    );
    console.log("filteredOrders:", filteredOrders);
  }

  const handleSave = () => {
    // Create an array of new fabric objects based on the selected fabrics
    const newFabrics = selectedFabrics.map((fabric) => {
      return {
        code: fabric.code,
        description: fabric.description,
      };
    });

    // Save the new fabrics to local storage
    const currentFabrics = JSON.parse(localStorage.getItem("fabrics")) || [];
    const updatedFabrics = [...currentFabrics, ...newFabrics];
    localStorage.setItem("fabrics", JSON.stringify(updatedFabrics));

    // Save the purchase order data to local storage
    const data = {
      setSelectedFabrics,
      fabricDescription,
    };
    const jsonData = JSON.stringify(data);
    console.log("selectedFabrics:", selectedFabrics);
    localStorage.setItem("purchaseOrder", jsonData);
  };

  const handleSelectFabric = (fabric) => {
    const newSelectedFabrics = [...selectedFabrics, fabric];
    setSelectedFabrics(newSelectedFabrics);
    console.log(newSelectedFabrics);
  };

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
                  <TableCell align="center">Desc</TableCell>
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
                        onChange={() => calculateTotal(row.id)}
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
          {/* <Box
            sx={{ width: 1 / 4 }}
            mx={1}
            display="auto"
            justifyContent="end"
            mt="20px"
          > */}
          <Stack
            direction="row"
            spacing={2}
            sx={{ width: 1 / 2 }}
            mx={1}
            display="flex"
            justifyContent="end"
            mt="20px"
          >
            <Button
              variant="contained"
              startIcon={<Save />}
              onClick={handleSave}
            >
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
