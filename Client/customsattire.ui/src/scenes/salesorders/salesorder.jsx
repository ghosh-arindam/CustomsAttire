import React, { useState, useEffect, useCallback } from "react";
import { Box, Button, TextField, MenuItem, Grid, Stack } from "@mui/material";
// import { tokens } from "../../theme";
import { v4 as uuidv4 } from "uuid";
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
import Typography from "@mui/material/Typography";
import Save from "@mui/icons-material/Save";
import Cancel from "@mui/icons-material/Cancel";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { addSalesOrders, loadCustomers } from "./../../redux/action";
import ProductDropDown from "../../components/ProductDropDown";

const SalesOrder = () => {
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const [customerName, setcustomerName] = useState("");
  /*eslint-disable-next-line */
  const [qty, setQty] = useState(0);
  const [deliveryDate, setDeliveryDate] = useState(new Date());
  /*eslint-disable-next-line */
  const [totalB, setTotalB] = useState(0);
  /*eslint-disable-next-line */
  const [discountA, setDiscountA] = useState(0);
  /*eslint-disable-next-line */
  const [discountB, setDiscountB] = useState(0);
  /*eslint-disable-next-line */
  const [stitchingCost, setStitchingCost] = useState(0);
  /*eslint-disable-next-line */
  const [grandTotal, setGrandTotal] = useState(0);
  /*eslint-disable-next-line */
  const [fabricDescription, setfabricDescription] = useState();
  /*eslint-disable-next-line */
  const [due, setDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState(0);
  const [inputDue, setInputDue] = useState(0);
  /*eslint-disable-next-line */
  const [quantity, setQuantity] = useState("");
  /*eslint-disable-next-line */
  const [price, setPrice] = useState("");
  /*eslint-disable-next-line */
  const [total, setTotal] = useState(0);
  /*eslint-disable-next-line */
  const [pricePerMeter, setpricePerMeter] = useState({});
  /*eslint-disable-next-line */
  const [purchaseItemwiseCost, setpurchaseItemwiseCost] = useState({});
  /*eslint-disable-next-line */
  const [totalBillAmount, settotalBillAmount] = useState(0);
  /*eslint-disable-next-line */
  const [advancePayment, setadvancePayment] = useState({});
  /*eslint-disable-next-line */
  const [duePayment, setduePayment] = useState({});
  const [rows, setRows] = useState([]);
  //const tableRef = useRef(null);

  useEffect(() => {
    //dispatch(loadSuppliers());
    dispatch(loadCustomers());

    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  const { customers } = useSelector((state) => state.data);
  const handleAdvChange = (e) => {
    const due = grandTotal - e.target.value;
    setInputAdvance(e.target.value);
    setInputDue(due);
  };

  const handleDateChange = (event) => {
    setDeliveryDate(event.target.value);
  };

  const calculateTotal = (rowId) => {
    const qty = parseFloat(document.getElementById(`qty${rowId}`).value);
    const price = parseFloat(document.getElementById(`price${rowId}`).value);
    const total = qty * price;
    document.getElementById(`total${rowId}`).innerText = total.toFixed(2);
  };

  const grandTotalA = (e, rowId) => {
    const total = parseFloat(
      document.getElementById(`total${rowId}`).innerText
    );
    const discountA = parseFloat(e.target.value);
    const grandTotalA = total - (total * discountA) / 100;
    document.getElementById(`grandTotalA${rowId}`).innerText =
      grandTotalA.toFixed(2);
    grandTotalAB(rowId); // add this line
  };

  const grandTotalB = (rowId) => {
    const discountB = parseFloat(
      document.getElementById(`discountB${rowId}`).value
    );
    const stitchingCost = parseFloat(
      document.getElementById(`stitchingCost${rowId}`).value
    );
    const grandTotalB = stitchingCost - (stitchingCost * discountB) / 100;
    document.getElementById(`grandTotalB${rowId}`).innerText =
      grandTotalB.toFixed(2);
    grandTotalAB(rowId); // add this line
  };

  const grandTotalAB = (rowId) => {
    const grandTotalA = parseFloat(
      document.getElementById(`grandTotalA${rowId}`).innerText
    );
    const grandTotalB = parseFloat(
      document.getElementById(`grandTotalB${rowId}`).innerText
    );
    const grandTotalAB = grandTotalA + grandTotalB;
    document.getElementById(`grandTotalAB${rowId}`).innerText =
      grandTotalAB.toFixed(2);
    settotalBillAmount(
      document.getElementById(`grandTotalAB${rowId}`).innerText
    );
  };

  const handleSelectFabricChange = useCallback((newValue) => {
    console.log("parentComponet" + newValue);
    setfabricDescription(newValue);
  }, []);

  const handleSubmit = (values) => {
    //dispatch(addPurchaseOrders(values));
    console.log(values);
    navigate("/dashboard");
  };

  const handleCustomerChange = (e) => {
    const customer = e.target.value;
    // console.log(vendorName);
    setcustomerName(customer);
    /*eslint-disable-next-line */
    const setfabricDescription = (event) => {
      console.log(event.target.value);
    };
  };

  const saveData = (event) => {
    event.preventDefault();
    const data = rows.map((row) => ({
      pricePerMeter: pricePerMeter[row.id],
      purchaseItemwiseCost: purchaseItemwiseCost[row.id],
      totalBillAmount: totalBillAmount[row.id],
      advancePayment: advancePayment[row.id],
      duePayment: duePayment[row.id],
      qty: qty[row.id],
      price: price[row.id],
      total: total[row.id],
      fabricDiscount: discountA[row.id],
      SwitchingDiscount: discountB[row.id],
      stitchingCost: stitchingCost[row.id],
      totalB: totalB[row.id],
      grandTotalA: grandTotalA[row.id],
      grandTotalB: grandTotalB[row.id],
      totalAB: grandTotalAB[row.id],
      deliveryDate: deliveryDate[row.id],
    }));
    localStorage.setItem("data", JSON.stringify(data));
    console.log(data);
    dispatch(addSalesOrders(data));
  };

  const addRow = () => {
    const newRow = {
      id: rows.length + 1,
      desc: "",
      qty: "",
      price: "",
      total: "0",
    };
    setRows([...rows, newRow]);
  };

  return (
    <Grid sx={{ flexGrow: 1 }} mx={4}>
      <Header title="SALES ORDER" subtitle="List of Sales Orders Made" />
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
            <Box sx={{ width: 1 / 4 }}></Box>
            <Box sx={{ mx: "left", p: 1, mt: 1 }}>
              <TextField
                align="left"
                id="outlined-select"
                select
                label="Customer"
                variant="outlined"
                onChange={handleCustomerChange}
                value={customerName || ""}
                defaultValue={"--SELECT A  CUSTOMER--"}
                name="customerName"
                //error={!!touched.supplierId && !!errors.supplierId}
                //helperText={touched.supplierId && errors.supplierId}
                sx={{
                  align: "left",
                  minWidth: 270,
                  maxWidth: 470,
                  pt: 1,
                  "& .MuiNativeSelect-select": { pt: "8.5px" },
                }}
              >
                {customers?.map((d, index) => (
                  <MenuItem
                    key={index}
                    // value={JSON.stringify({
                    //   id: d.id,
                    //   name: d.vendorname,
                    // })}
                    value={d.firstName}
                  >
                    {d.firstName + " " + d.lastName}
                  </MenuItem>
                ))}
              </TextField>
            </Box>
          </Box>
          <Box sx={{ width: 1 / 2 }}></Box>
          <Box
            align="right"
            gridTemplateColumns="repeat(3, minmax(0, 1fr))"
            sx={{ mx: "right", p: 1, mt: 1 }}
          >
            <Box align="right" name="billHeaderId" value="billHeaderId">
              OrderId:
              {uuidv4()}
            </Box>
            <Button
              variant="contained"
              color="primary"
              startIcon={<AddIcon />}
              size="medium"
              onClick={addRow}
            >
              Add Sales Orders
            </Button>
          </Box>
        </Box>
        <Box my={4}>
          <TableContainer
            component={Paper}
            // sx={{ maxwidth: "2000", maxheight: "2000", overflow: "auto" }}
          >
            <Table sx={{ minWidth: 900 }}>
              <TableHead>
                <TableRow>
                  <TableCell align="left" colSpan={1}>
                    SL NO
                  </TableCell>
                  <TableCell align="left" colSpan={1}>
                    Fabric Code
                  </TableCell>
                  <TableCell align="left" colSpan={1}>
                    Description
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Outfit Type
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Quantity
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Price
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Total
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Discount (A)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (A)
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Stitching Cost
                  </TableCell>
                  <TableCell align="center" colSpan={1}>
                    Discount (B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Grand Total (B)
                  </TableCell>
                  <TableCell align="right" colSpan={1}>
                    Total (A+B)
                  </TableCell>
                  <TableCell align="right" colSpan={1} />
                  <TableCell align="right" colSpan={2}>
                    Trial Date
                  </TableCell>
                </TableRow>
              </TableHead>
              <TableBody>
                {rows?.map((row, index) => (
                  <TableRow key={row.id}>
                    <TableCell colSpan={1}>{index + 1}</TableCell>
                    <TableCell colSpan={1}>
                      <ProductDropDown
                        id={`fabricCode${row.id}`}
                        value={fabricDescription}
                        onChange={handleSelectFabricChange}
                      />
                    </TableCell>
                    <TableCell align="right" colSpan={1} name="fabricDesc">
                      {fabricDescription}
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Outfit Type"
                            type="text"
                            id={`clothType${row.id}`}
                            name="clothType"
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Quantity"
                            type="number"
                            id={`qty${row.id}`}
                            name="qty"
                            onChange={(e) => {
                              const { value } = e.target;
                              setQty((prevQty) => ({
                                ...prevQty,
                                [row.id]: value,
                              }));
                              calculateTotal(row.id);
                            }}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Price"
                            type="number"
                            id={`price${row.id}`}
                            name="pricePerMeter"
                            onChange={() => calculateTotal(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography
                        id={`total${row.id}`}
                        onChange={(e) => calculateTotal(e.target.value)}
                      ></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Discount (A)"
                            type="number"
                            name="fabricDiscount"
                            id={`discountA${row.id}`}
                            onChange={(e) => grandTotalA(e, row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalA${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Stitching Cost"
                            type="number"
                            id={`stitchingCost${row.id}`}
                            onChange={() => grandTotalB(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Grid container alignItems="center" justify="flex-end">
                        <Grid item>
                          <TextField
                            label="Discount(B)"
                            type="number"
                            id={`discountB${row.id}`}
                            onChange={() => grandTotalB(row.id)}
                          />
                        </Grid>
                      </Grid>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalB${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}>
                      <Typography id={`grandTotalAB${row.id}`}></Typography>
                    </TableCell>
                    <TableCell align="right" colSpan={1}></TableCell>
                    <TableCell align="right" colSpan={1}></TableCell>
                    <TableCell align="center" colSpan={1}>
                      <TextField
                        align="right"
                        label="Calendar"
                        type="date"
                        defaultValue={new Date()}
                        InputLabelProps={{
                          shrink: true,
                        }}
                      />
                    </TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
            <Box>
              <TableRow>
                <TableCell
                  rowSpan={2}
                  style={{ borderBottom: "none" }}
                  sx={{ width: 1 / 2, "& td": { border: 0 } }}
                />
                <TableCell sx={{ width: 1 / 4 }} colSpan={6}>
                  Total
                </TableCell>
                <TableCell align="right" colSpan={4}>
                  {totalBillAmount}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                  Advance
                </TableCell>
                <TableCell colSpan={4}>
                  <TextField
                    label="Advance"
                    value={inputAdvance}
                    name="paymentdone"
                    onChange={handleAdvChange}
                    sx={{
                      align: "right",
                      minWidth: 270,
                      maxWidth: 470,
                      pt: 1,
                      // "& .MuiNativeSelect-select": { pt: "8.5px" },
                    }}
                  ></TextField>
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell
                  rowSpan={2}
                  style={{ borderBottom: "none" }}
                  sx={{ width: 1 / 2, "& td": { border: 0 } }}
                />
                <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                  Total Due
                </TableCell>
                <TableCell align="right" colSpan={3}>
                  {inputDue}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell sx={{ width: 1 / 4 }} colSpan={4}>
                  Delivery Date
                </TableCell>
                <TableCell colSpan={3} align="right">
                  <TextField
                    label="Calendar"
                    type="date"
                    defaultValue={new Date()}
                    InputLabelProps={{
                      shrink: true,
                    }}
                    value={deliveryDate}
                    onChange={handleDateChange}
                  />
                </TableCell>
              </TableRow>
            </Box>
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

export default SalesOrder;
