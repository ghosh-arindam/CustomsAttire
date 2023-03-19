import React, { useState, useEffect, useRef } from "react";
import { Box, Button, TextField, MenuItem, Grid, Select } from "@mui/material";
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
import { useDispatch, useSelector } from "react-redux";
import { loadSuppliers } from "./../../redux/action";
import { addPurchaseOrders } from "./../../redux/action";
import { loadProduct } from "./../../redux/action";
//import ProductDropDownComponent from "../../components/ProductDropDown";
import { useNavigate } from "react-router-dom";
//import { Formik } from "formik";

const PurchaseOrders = () => {
  //const theme = useTheme();
  //const colors = tokens(theme.palette.mode);
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const navigate = useNavigate();
  const [selectedVendor, setSelectedVendor] = useState("");
  const [total, setTotal] = useState(0);
  const [grandTotal, setGrandTotal] = useState(0);
  const [fabricDescription, setfabricDescription] = useState();
  const [due, setDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState(0);
  const [inputDue, setInputDue] = useState(0);

  // const [selectedFabric, setSelectedFabric] = useState("");
  // const [fabricDesc, setfabricDesc] = useState();
  // const [fabricState, setFabricState] = useState();
  //const [fabricDesc, setFabricDesc] = useState("");
  const dispatch = useDispatch();
  const [rows, setRows] = useState([]);

  const { suppliers } = useSelector((state) => state.data);
  const { Products } = useSelector((state) => state.data);

  //const  = useSelector((state) => state.data);
  const tableRef = useRef(null);

  useEffect(() => {
    dispatch(loadSuppliers());
    dispatch(loadProduct());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, [selectedVendor]);

  const handleAdvChange = (e) => {
    const due = grandTotal - e.target.value;
    setInputAdvance(e.target.value);
    setInputDue(due);
  };

  console.log(Products);
  const calculateTotal = (rowId) => {
    const qty = document.getElementById(`qty${rowId}`).value;
    const price = parseFloat(document.getElementById(`price${rowId}`).value);
    const total = qty * price;
    document.getElementById(`total${rowId}`).innerText = total.toFixed(2);

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
  // console.log(suppliers);
  //console.log(Products);

  // const handleSelectFabricChange = (index, event) => {
  //   const { name, value } = event.target;
  //   console.log(event.target.value);
  //   console.log(event.target.name);
  //   // const fabricDescription = Products.find(
  //   //   (u) => u.description === event.target.value
  //   // );
  //   const rowsInput = [...rows];
  //   rowsInput[index][name] = value;
  //   console.log(value);
  //   setfabricDesc(event.target.value);
  //   setFabricState(event.target.value);
  // };
  const handleVendorChange = (event) => {
    setSelectedVendor(event.target.value);
    //setSelectedFabric("");
    //setFabricDesc("");
  };
  // const handleFabricChange = (event) => {
  //   setSelectedFabric(event.target.value);
  // };
  const handleSubmit = (values) => {
    dispatch(addPurchaseOrders(values));
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
            <TextField
              id="outlined-select"
              select
              label="Select Vendor"
              variant="outlined"
              onChange={handleVendorChange}
              value={selectedVendor || ""}
              defaultValue={"--SELECT A  VENDOR--"}
              name="supplierId"
              //error={!!touched.supplierId && !!errors.supplierId}
              //helperText={touched.supplierId && errors.supplierId}
              sx={{
                align: "right",
                minWidth: 270,
                maxWidth: 470,
                pt: 1,
                "& .MuiNativeSelect-select": { pt: "8.5px" },
              }}
            >
              {suppliers?.map((d, index) => (
                <MenuItem
                  key={d.id}
                  value={JSON.stringify({
                    id: d.id,
                    name: d.vendorname,
                  })}
                >
                  {d.vendorName}
                </MenuItem>
              ))}
            </TextField>
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
                    {/* <TableCell>{row.fabricCode}</TableCell> */}
                    <TableCell>
                      {/* <TextField
                      id="outlined-select"
                      select
                      label="Select Fabric"
                      variant="outlined"
                      style={{ width: 150 }}
                      onChange={(event) =>
                        handleSelectFabricChange(index, event)
                      }
                      InputLabelProps={{
                        shrink: true,
                      }}
                      value={fabricState || ""}
                      defaultValue={""}
                      name="fabricCode"
                      sx={{ gridColumn: "span 4" }}
                    >
                      {Products?.map((d, index) => (
                        <MenuItem key={d.id} value={d.description}>
                          {d.fabricCode}
                        </MenuItem>
                      ))}
                      :<div></div>
                    </TextField> */}
                      <Select
                        value={row.fabricCode}
                        onChange={(e, index) => {
                          row = e.target.value;
                          console.log("row" + row);
                          // const fabric = Products.find(
                          //   (f) => f.description === e.target.value
                          // );
                          // console.log("fabric" + fabric);
                          setfabricDescription(row);
                        }}
                      >
                        <MenuItem value="">Select a fabric</MenuItem>
                        {Products.map((fabric, index) => (
                          <MenuItem key={fabric.id} value={fabric.description}>
                            {fabric.fabricCode}
                          </MenuItem>
                        ))}
                      </Select>
                      {/* <ProductDropDownComponent /> */}
                    </TableCell>
                    <TableCell>{fabricDescription}</TableCell>
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
          <Box
            sx={{ width: 1 / 2 }}
            mx={4}
            display="flex"
            justifyContent="end"
            mt="20px"
          >
            <Button
              type="submit"
              variant="contained"
              color="primary"
              startIcon={<Save />}
              size="medium"
            >
              Save
            </Button>
          </Box>
        </Box>
      </form>
    </Grid>
  );
};

export default PurchaseOrders;
