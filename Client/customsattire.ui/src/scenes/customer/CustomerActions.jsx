import { Check, Delete, Save } from "@mui/icons-material";
import { Box, CircularProgress, Fab } from "@mui/material";
import { green, blue } from "@mui/material/colors";
import React, { useState, useEffect } from "react";
import { useDispatch } from "react-redux";
import { deleteCustomer, updateCustomers } from "../../redux/action";

const CustomerActions = ({ params, selectedrowId, setselectedrowId }) => {
  const [loading, setLoading] = useState(false);
  const [success, setSuccess] = useState(false);
  const dispatch = useDispatch();
  const delay = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

  const handleSubmit = async () => {
    setLoading(true);
    await delay(2000);
    const {
      rowId,
      title,
      firstName,
      lastName,
      emailId,
      phoneNo,
      address1,
      address2,
      gender,
      dob,
      anniversarydate,
      id,
    } = params.row;
    // console.log("handleSubmit:" + params.row);
    // console.log("id:" + id);
    const customerdata = {
      rowId,
      title,
      firstName,
      lastName,
      emailId,
      phoneNo,
      address1,
      address2,
      gender,
      dob,
      anniversarydate,
    };
    //console.log("handleSubmit:" + customerdata);
    const result = dispatch(updateCustomers(customerdata, id));
    //console.log("result:" + result);
    if (result) {
      setSuccess(true);
      setselectedrowId(null);
    }
    setLoading(false);
  };
  const handleDelete = async (e, id) => {
    if (window.confirm("Are you sure to delete the Customer?")) {
      e.stopPropagation();
      dispatch(deleteCustomer(id));
    }
  };

  useEffect(() => {
    // console.log("selectedrowId" + selectedrowId);
    // console.log("params.id" + params.id);
    if (selectedrowId === params.id && success) setSuccess(false);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [selectedrowId]);
  return (
    <Box
      sx={{
        m: 1,
        position: "relative",
      }}
    >
      {success ? (
        <Fab
          color="primary"
          sx={{
            width: 40,
            height: 40,
            bgcolor: green[500],
            "&:hover": { bgcolor: green[700] },
          }}
        >
          <Check />
        </Fab>
      ) : (
        <Fab
          color="primary"
          sx={{
            width: 40,
            height: 40,
          }}
          disabled={params.id !== selectedrowId || loading}
          onClick={handleSubmit}
        >
          <Save />
        </Fab>
      )}
      {loading && (
        <CircularProgress
          size={52}
          sx={{
            color: green[500],
            position: "absolute",
            top: -6,
            left: -6,
            zIndex: 1,
          }}
        />
      )}

      <Fab
        color="secondary"
        sx={{
          mr: 1,
          width: 40,
          height: 40,
          bgcolor: blue[500],
          "&:hover": { bgcolor: green[700] },
        }}
        onClick={(e) => handleDelete(e, params.id)}
      >
        <Delete />
      </Fab>
    </Box>
  );
};

export default CustomerActions;
