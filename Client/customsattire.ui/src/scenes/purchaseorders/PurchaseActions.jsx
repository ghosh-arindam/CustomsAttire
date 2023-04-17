import { Check, Delete, Save } from "@mui/icons-material";
import { Box, CircularProgress, Fab } from "@mui/material";
import { green, blue } from "@mui/material/colors";
import React, { useState, useEffect } from "react";
import { useDispatch } from "react-redux";
import { deletePurchase } from "../../redux/action";

const PurchaseActions = ({ params, rowId, setrowId }) => {
  const [loading, setLoading] = useState(false);
  const [success, setSuccess] = useState(false);
  const dispatch = useDispatch();

  const handleSubmit = async () => {
    setLoading(false);
  };

  const handleDelete = async (id) => {
    if (window.confirm("Are you sure to delete the Purchase?")) {
      dispatch(deletePurchase(id));
    }
  };

  useEffect(() => {
    if (rowId === params.id && success) setSuccess(false);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [rowId]);
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
          disabled={params.id !== rowId || loading}
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
        onClick={() => handleDelete(params.id)}
      >
        <Delete />
      </Fab>
    </Box>
  );
};

export default PurchaseActions;
